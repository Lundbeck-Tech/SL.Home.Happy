/*
    @Date                 : 24.03.2024
    @Author               : Stein Lundbeck
    @Description          : null
*/

using LC.Assets.Core;
using LC.Assets.Core.Components;
using LC.Assets.Core.Components.ApplicationFeatures;

WebApplicationBuilder bld = WebApplication.CreateBuilder(args);

AssetsConfig.AddAssets(bld,
    new SSL(),
    new Minify(MinifyTargets.Production),
    new Localization(),
    new DefaultRoute("SL", "Index"));
