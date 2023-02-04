# 特異点近傍における強化学習でのロボット制御の可能性

<img src="https://img.shields.io/badge/-Unity%202021.3.11f1-000000.svg?logo=unity&style=plastic">  

## 背景
特異点はロボットの制御において、動作の不安定さにより避けられてきた姿勢である。[1]  
特異点はロボットの関節の角度がゼロになることで、数学的に解が出せなくなり制御不可能になる。[2]  
通常、ロボット制御において特異点は回避するようにプログラムされている。  
特異点近傍では、特異点を回避した動きをしなければならないため、少しの移動でアームを大きく動かす必要があり、ロボットアームが暴れてしまう。  

[1] Singularity-Based Four-Bar Linkage Mechanism for Impulsive Torque With High Energy Efficiency  
[2] [SIerによるロボット解説、安定動作の為の特異点回避方法](https://jss1.jp/column/column_264/#i-6)  

## 目的
今回は、強化学習を用いて特異点近傍におけるロボット制御を行い、動作の暴れを解消した安定制御を行えるか可能性を検証する。  

## 先行研究
強化学習による多自由度２足歩行ロボットの制御の研究があり、人の歩き方に注目した歩行を強化学習で実現しようとした。[3]  
[3] [強化学習による多自由度２足歩行ロボットの制御](https://www.ai-gakkai.or.jp/jsai2005/schedule/pdf/000229.pdf)  

## 強化学習の環境
シミュレータ：Unity  
エージェント：ロボットアーム  
ターゲット：ボールオブジェクト  

## インストール
