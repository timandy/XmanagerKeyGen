# Xmanager Power Suit 注册机

## 下载安装包
[下载地址](https://www.netsarang.com/download/software.html)

- Xmanger Power Suit 有两种安装包，分别是试用版和正式版。试用版无法输入注册码，到期失效。正式版可以输入注册码进行激活。
- 在下载页面点击下载，选择 `Evaluation user`，填写邮箱等信息(有些邮箱接收不到邮件，例如 126 邮箱无法收到邮件)。
- 查收邮件，通过下载地址下载安装包。注意下载的安装包是试用版。正式版的下载地址为 试用版地址 `.exe` 前加上字母 `r`。

```
试用版
https://cdn.netsarang.net/bfa85108/XmanagerPowerSuite-6.0.0008.exe

零售版
https://cdn.netsarang.net/bfa85108/XmanagerPowerSuite-6.0.0008r.exe
``` 

## 修改 hosts

- 使用文本编辑器打开 `C:\Windows\System32\drivers\etc\hosts`。
- 添加以下文本：
```
127.0.0.1 activate.netsarang.com
127.0.0.1 sales.netsarang.com
127.0.0.1 transact.netsarang.com
127.0.0.1 update.netsarang.com
127.0.0.1 www.netsarang.co.kr
127.0.0.1 www.netsarang.com
```

## 安装
[注册机](https://github.com/timandy/XmanagerKeyGen)
- 运行安装程序。
- 输入注册机生成的注册码。
- 安装完成。

## 激活
- 确认已修改 `hosts`。
- 关闭 `Xshell` 进程，删除注册表 `HKEY_CURRENT_USER\Software\NetSarang`。
- 重新打开 `Xshell` 显示已注册。

## 参考
[原文链接](https://blog.csdn.net/the_liang/article/details/82708907)

[算法参考](https://github.com/DoubleLabyrinth/Xmanager-keygen)
