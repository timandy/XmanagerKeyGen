# Xmanager Power Suit 注册机

## 下载安装包
[下载地址](https://www.netsarang.com/download/software.html)

- Xmanger Power Suit 有两种安装包。一种试用版，一种正式。试用版无法输入注册码，到期失效。注册版可以输入注册码进行激活。
- 在下载页面点击下载，选择试用用户，填写邮箱等信息(有些邮箱接收不到邮件，例如 126)
- 查收邮件，通过下载地址下载安装包。注意下载的安装包是试用版。正式版的下载地址为 试用版地址 `.exe` 前插入 `r`。

```
试用版
https://cdn.netsarang.net/bfa85108/XmanagerPowerSuite-6.0.0008.exe

正式版
https://cdn.netsarang.net/bfa85108/XmanagerPowerSuite-6.0.0008r.exe
``` 

## 添加 HOSTS 信息

- 路径 `C:\Windows\System32\drivers\etc`
```
127.0.0.1 transact.netsarang.com
127.0.0.1 update.netsarang.com
127.0.0.1 www.netsarang.com
127.0.0.1 www.netsarang.co.kr
127.0.0.1 sales.netsarang.com
```

## 使用 XmanagerKeygen 生成序列号
[注册机](https://github.com/timandy/XmanagerKeyGen)
- 使用注册机生成注册码
- 安装时输入注册码

## 激活失败问题
- **如果在修改 HOSTS 前已经联网激活失败过,则无法激活**
- 解决方法: 退出 `XShell`， 删除注册表 `HKEY_CURRENT_USER\Software\NetSarang`， 重新打开，显示已经激活。

## 参考
[原文链接](https://blog.csdn.net/the_liang/article/details/82708907)

[算法参考](https://github.com/DoubleLabyrinth/Xmanager-keygen)
