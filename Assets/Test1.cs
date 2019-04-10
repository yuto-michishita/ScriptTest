using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {
//Bossクラス：更新されるmpに応じて文を出力する
	public class Boss{
		//初期mp
		int mp=53;
//magic関数
		public void magic(int damage){
			//mpからダメージが引ける場合
			if (this.mp >= damage) {
				//mpからダメージを引く
				this.mp = this.mp - damage;
				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
				//引けなくなったら（次引いたらマイナスになる）
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
	}




	// Use this for initialization
	void Start () {
		int i;
		//Bossのインスタンスbossを作り、代入
		Boss boss = new Boss ();
		//mpを減らしてみる
		for (i = 0; i <= 12; i++) {
			boss.magic (5);
		}
	}
}