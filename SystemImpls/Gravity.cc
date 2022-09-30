#include "example.ecsact.systems.hh"

void example::Gravity::impl(context& ctx) {
	auto pos = ctx.get<Position>();
	pos.y -= 0.1f;
	ctx.update(pos);
}
