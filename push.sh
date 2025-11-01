#!/bin/bash

echo "开始强制推送到公共仓库..."
echo "时间: $(date)"

# 添加所有文件
git add .

# 提交
commit_msg="r$(date +%m%d%H%M)"
git commit -m "$commit_msg" --allow-empty
echo "已提交: $commit_msg"

# 强制推送到公共仓库
echo "🌐 正在推送到公共仓库..."
git push https://github.com/dxwong/NPFormUI.git main --force || {
    echo " 网络异常！推送失败，请检查网络连接后重试"
    read -p "按回车键退出..."
    exit 1
}


echo "推送完成 时间: $(date)"
read -p "按回车键退出..."