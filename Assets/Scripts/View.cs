using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    ViewerGroup viewerGroup;
    Stream stream;
    int views;
    int subscription;

    public static double streamViewWeight = 1.2, matchingGenderWeight = 1.2, matchingStyleWeight = 1.2 , playerPopularityWeight = 1.2, gamePopularityWeight = 1.2, gameSkillWeight = 1.2, hypeChaserWeight = 1.2, proWatcherWeight = 1.2, fameFollowerWeight = 1.2;

    public double CalcViewPossibility()
    {
        double matchingGenderBonus;
        if ((viewerGroup.HasTrait(ViewerGroup.Trait.MaleFollower) && stream.player.gender == Player.Gender.male) || (viewerGroup.HasTrait(ViewerGroup.Trait.FemaleFollower) && stream.player.gender == Player.Gender.female))
        {
            matchingGenderBonus = matchingGenderWeight;
        }
        else matchingGenderBonus = 1;

        double matchingStyleBonus;
        if (stream.playStyle == viewerGroup.favStyle) matchingStyleBonus = matchingStyleWeight; else matchingStyleBonus = 1;

        return
            ((stream.views * streamViewWeight) +
            (stream.game.popularity * gamePopularityWeight * (viewerGroup.HasTrait(ViewerGroup.Trait.HypeChaser) ? hypeChaserWeight : 1) +
            (stream.player.popularity * playerPopularityWeight * (viewerGroup.HasTrait(ViewerGroup.Trait.FameFollower) ? fameFollowerWeight : 1) +
            (stream.player.gameSkill.Find(g => g.game == stream.game).skill * gameSkillWeight * (viewerGroup.HasTrait(ViewerGroup.Trait.ProWatcher) ? proWatcherWeight : 1))))) *
            (matchingGenderBonus * matchingStyleBonus);

    }
}
