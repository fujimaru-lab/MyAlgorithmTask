package main

import (
	"fmt"
	"math/rand"
	"time"
)

// NUM 乱数生成回数
const NUM int = 1000000

// 1/4の円の中に二つの乱数により座標指定した点がいくつ生成されたかによってπを求める
func main() {
	count := 0
	for i := 0; i < NUM; i++ {
		rand.Seed(time.Now().UnixNano())
		px := rand.Float32()
		py := rand.Float32()

		if px*px+py*py < 1 {
			count++
		}
	}
	pai := float64(count*4) / float64(NUM)

	fmt.Println("pai =", pai)
}
