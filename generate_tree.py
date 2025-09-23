import os

def generate_tree(path='.', prefix=''):
    tree = ''
    for item in sorted(os.listdir(path)):
        if item.startswith('.') or item in ['.git', '.github', '__pycache__']:
         continue
        full_path = os.path.join(path, item)
        if os.path.isdir(full_path):
            tree += f"{prefix}📁 {item}/\n"
            tree += generate_tree(full_path, prefix + '│   ')
        else:
            tree += f"{prefix}├── {item}\n"
    return tree

def update_readme(tree_text):
    with open('README.md', 'r', encoding='utf-8') as f:
        content = f.read()

    start = '<!-- Project tree starts here -->'
    end = '<!-- Project tree ends here -->'
    before = content.split(start)[0] + start + '\n\n'
    after = '\n' + end + content.split(end)[1]
    new_content = before + '```\n' + tree_text + '```\n' + after

    with open('README.md', 'w', encoding='utf-8') as f:
        f.write(new_content)

if __name__ == '__main__':
    tree = (
    generate_tree('./') +
    generate_tree('Week1_Basics') +
    generate_tree('Week2_Loops/') +
    generate_tree('Week3_Conditions/') +
    generate_tree('Week4_Functions/') +
    generate_tree('Week5_Arrays/') +
    generate_tree('Week6_FinalProject/')
)
    update_readme(tree)
