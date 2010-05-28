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
		internal static global::net.sf.jni4net.jni.MethodId _clone8896; 
		protected virtual new global::android.view.animation.AnimationSet clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.AnimationSet._clone8896)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._clone8896)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset8897; 
		public override void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._reset8897); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._reset8897); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize8898; 
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._initialize8898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._initialize8898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset8899; 
		public override void setStartOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setStartOffset8899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartOffset8899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration8900; 
		public override void setDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setDuration8900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setDuration8900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration8901; 
		public override void restrictDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._restrictDuration8901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._restrictDuration8901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration8902; 
		public override void scaleCurrentDuration(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._scaleCurrentDuration8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._scaleCurrentDuration8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime8903; 
		public override void setStartTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setStartTime8903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartTime8903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode8904; 
		public override void setRepeatMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setRepeatMode8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setRepeatMode8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore8905; 
		public override void setFillBefore(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setFillBefore8905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillBefore8905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter8906; 
		public override void setFillAfter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._setFillAfter8906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillAfter8906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime8907; 
		public override long getStartTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._getStartTime8907); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getStartTime8907); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration8908; 
		public override long getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._getDuration8908); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getDuration8908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix8909; 
		public override bool willChangeTransformationMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._willChangeTransformationMatrix8909); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeTransformationMatrix8909); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds8910; 
		public override bool willChangeBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._willChangeBounds8910); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeBounds8910); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint8911; 
		public override long computeDurationHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, global::android.view.animation.AnimationSet._computeDurationHint8911); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._computeDurationHint8911); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation8912; 
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, global::android.view.animation.AnimationSet._getTransformation8912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getTransformation8912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAnimation8913; 
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, global::android.view.animation.AnimationSet._addAnimation8913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._addAnimation8913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimations8914; 
		public virtual global::java.util.List getAnimations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.AnimationSet._getAnimations8914)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getAnimations8914)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet8915; 
		public AnimationSet(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet8915, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet8916; 
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet8916, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.AnimationSet.staticClass = @__class; 
			global::android.view.animation.AnimationSet._clone8896 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;"); 
			global::android.view.animation.AnimationSet._reset8897 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "reset", "()V"); 
			global::android.view.animation.AnimationSet._initialize8898 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V"); 
			global::android.view.animation.AnimationSet._setStartOffset8899 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V"); 
			global::android.view.animation.AnimationSet._setDuration8900 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V"); 
			global::android.view.animation.AnimationSet._restrictDuration8901 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V"); 
			global::android.view.animation.AnimationSet._scaleCurrentDuration8902 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V"); 
			global::android.view.animation.AnimationSet._setStartTime8903 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V"); 
			global::android.view.animation.AnimationSet._setRepeatMode8904 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V"); 
			global::android.view.animation.AnimationSet._setFillBefore8905 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V"); 
			global::android.view.animation.AnimationSet._setFillAfter8906 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V"); 
			global::android.view.animation.AnimationSet._getStartTime8907 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J"); 
			global::android.view.animation.AnimationSet._getDuration8908 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J"); 
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix8909 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z"); 
			global::android.view.animation.AnimationSet._willChangeBounds8910 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z"); 
			global::android.view.animation.AnimationSet._computeDurationHint8911 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J"); 
			global::android.view.animation.AnimationSet._getTransformation8912 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z"); 
			global::android.view.animation.AnimationSet._addAnimation8913 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.animation.AnimationSet._getAnimations8914 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;"); 
			global::android.view.animation.AnimationSet._AnimationSet8915 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V"); 
			global::android.view.animation.AnimationSet._AnimationSet8916 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
