// GENERATED FILE - DO NOT EDIT

#nullable enable

namespace example {

public struct Player : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 1;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Player)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct Health : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 2;
	public global::System.Byte value;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Health)obj;
		return true
			&& other_.value.Equals(this.value);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + value.GetHashCode();
		return hashCode_;
	}
}

public struct Attacking : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 3;
	public global::System.Int32 target;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Attacking)obj;
		return true
			&& other_.target.Equals(this.target);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + target.GetHashCode();
		return hashCode_;
	}
}

public struct Position : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 4;
	public global::System.Single x;
	public global::System.Single y;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Position)obj;
		return true
			&& other_.x.Equals(this.x)
			&& other_.y.Equals(this.y);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + x.GetHashCode();
		hashCode_ = hashCode_ * 23 + y.GetHashCode();
		return hashCode_;
	}
}

public struct Bullet : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 5;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Bullet)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct Attack : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 6;
	public global::System.Int32 target;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Attack)obj;
		return true
			&& other_.target.Equals(this.target);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + target.GetHashCode();
		return hashCode_;
	}
}

public struct Shoot : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 7;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Shoot)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}
public struct AttackDamage : global::Ecsact.System {
	public static readonly global::System.Int32 id = 9;
}
public struct Gravity : global::Ecsact.System {
	public static readonly global::System.Int32 id = 10;
}

}
