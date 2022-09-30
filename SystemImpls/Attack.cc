#include "example.ecsact.systems.hh"

void example::Attack::impl(context& ctx) {
	ctx.add(Attacking{.target = ctx.action().target});
}

void example::AttackDamage::impl(context& ctx) {
	// TODO
}

void example::Shoot::impl(context& ctx) {
	// TODO
}
