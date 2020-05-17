package main

import (
	"fmt"
	"math/rand"
	"time"
)

// MAX 作成する数列の最大値
const MAX int = 32

func main() {
	// ランダム数列
	rndPerm := make([]int, MAX)

	// 数列の初期化
	for i := 0; i < MAX; i++ {
		rndPerm[i] = i + 1
	}

	fmt.Println("処理前:", rndPerm)

	// シードの初期化
	rand.Seed(time.Now().UnixNano())

	// ランダムな順列の生成処理
	for n := MAX; n >= 1; n-- {
		// 処理対象の配列の位置を疑似乱数で指定
		index := rand.Intn(n)

		// 配列の中身を相互に置換
		tmp := rndPerm[index]
		rndPerm[index] = rndPerm[n-1]
		rndPerm[n-1] = tmp
	}

	fmt.Println("処理後:", rndPerm)
}
