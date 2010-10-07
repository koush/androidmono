namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AnimationSet : android.view.animation.Animation
	{
		internal new static global::java.lang.Class staticClass;
		static AnimationSet()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AnimationSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.AnimationSet(@__env);
			}
		}
		protected AnimationSet(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone9603;
		protected virtual new global::android.view.animation.AnimationSet clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.AnimationSet._clone9603));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._clone9603));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset9604;
		public override void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._reset9604);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._reset9604);
		}
		internal static global::net.sf.jni4net.jni.MethodId _initialize9605;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._initialize9605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._initialize9605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset9606;
		public override void setStartOffset(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setStartOffset9606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartOffset9606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDuration9607;
		public override void setDuration(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setDuration9607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setDuration9607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration9608;
		public override void restrictDuration(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._restrictDuration9608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._restrictDuration9608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration9609;
		public override void scaleCurrentDuration(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._scaleCurrentDuration9609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._scaleCurrentDuration9609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime9610;
		public override void setStartTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setStartTime9610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartTime9610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode9611;
		public override void setRepeatMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setRepeatMode9611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setRepeatMode9611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore9612;
		public override void setFillBefore(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setFillBefore9612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillBefore9612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter9613;
		public override void setFillAfter(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setFillAfter9613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillAfter9613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime9614;
		public override long getStartTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._getStartTime9614);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getStartTime9614);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration9615;
		public override long getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._getDuration9615);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getDuration9615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix9616;
		public override bool willChangeTransformationMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._willChangeTransformationMatrix9616);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeTransformationMatrix9616);
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds9617;
		public override bool willChangeBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._willChangeBounds9617);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeBounds9617);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint9618;
		public override long computeDurationHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._computeDurationHint9618);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._computeDurationHint9618);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation9619;
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._getTransformation9619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getTransformation9619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAnimation9620;
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._addAnimation9620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._addAnimation9620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimations9621;
		public virtual global::java.util.List getAnimations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.AnimationSet._getAnimations9621));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getAnimations9621));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet9622;
		public AnimationSet(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet9622, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet9623;
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet9623, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.AnimationSet.staticClass = @__class;
			global::android.view.animation.AnimationSet._clone9603 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;");
			global::android.view.animation.AnimationSet._reset9604 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "reset", "()V");
			global::android.view.animation.AnimationSet._initialize9605 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.AnimationSet._setStartOffset9606 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.AnimationSet._setDuration9607 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V");
			global::android.view.animation.AnimationSet._restrictDuration9608 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.AnimationSet._scaleCurrentDuration9609 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.AnimationSet._setStartTime9610 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.AnimationSet._setRepeatMode9611 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.AnimationSet._setFillBefore9612 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.AnimationSet._setFillAfter9613 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.AnimationSet._getStartTime9614 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J");
			global::android.view.animation.AnimationSet._getDuration9615 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J");
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix9616 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AnimationSet._willChangeBounds9617 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AnimationSet._computeDurationHint9618 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.AnimationSet._getTransformation9619 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.AnimationSet._addAnimation9620 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.AnimationSet._getAnimations9621 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;");
			global::android.view.animation.AnimationSet._AnimationSet9622 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V");
			global::android.view.animation.AnimationSet._AnimationSet9623 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
