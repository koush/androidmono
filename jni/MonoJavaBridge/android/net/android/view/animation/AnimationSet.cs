namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnimationSet : android.view.animation.Animation
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AnimationSet() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.AnimationSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clone8254; 
		protected virtual new android.view.animation.AnimationSet clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallObjectMethodPtr(this, _clone8254)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.AnimationSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.AnimationSet.staticClass, _clone8254)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset8255; 
		public override void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _reset8255); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _reset8255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize8256; 
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _initialize8256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _initialize8256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset8257; 
		public override void setStartOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setStartOffset8257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setStartOffset8257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration8258; 
		public override void setDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setDuration8258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setDuration8258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration8259; 
		public override void restrictDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _restrictDuration8259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _restrictDuration8259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration8260; 
		public override void scaleCurrentDuration(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _scaleCurrentDuration8260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _scaleCurrentDuration8260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime8261; 
		public override void setStartTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setStartTime8261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setStartTime8261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode8262; 
		public override void setRepeatMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setRepeatMode8262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setRepeatMode8262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore8263; 
		public override void setFillBefore(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setFillBefore8263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setFillBefore8263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter8264; 
		public override void setFillAfter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _setFillAfter8264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _setFillAfter8264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime8265; 
		public override long getStartTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, _getStartTime8265); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.AnimationSet.staticClass, _getStartTime8265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration8266; 
		public override long getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, _getDuration8266); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.AnimationSet.staticClass, _getDuration8266); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix8267; 
		public override bool willChangeTransformationMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, _willChangeTransformationMatrix8267); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.AnimationSet.staticClass, _willChangeTransformationMatrix8267); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds8268; 
		public override bool willChangeBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, _willChangeBounds8268); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.AnimationSet.staticClass, _willChangeBounds8268); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint8269; 
		public override long computeDurationHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallLongMethod(this, _computeDurationHint8269); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.AnimationSet.staticClass, _computeDurationHint8269); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation8270; 
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return @__env.CallBooleanMethod(this, _getTransformation8270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.AnimationSet.staticClass, _getTransformation8270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAnimation8271; 
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				@__env.CallVoidMethod(this, _addAnimation8271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.AnimationSet.staticClass, _addAnimation8271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimations8272; 
		public virtual java.util.List getAnimations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.AnimationSet)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getAnimations8272)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.AnimationSet.staticClass, _getAnimations8272)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet8273; 
		public AnimationSet(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, _AnimationSet8273, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationSet8274; 
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnimationSet.staticClass, _AnimationSet8274, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.AnimationSet.staticClass = @__class; 
			global::android.view.animation.AnimationSet._clone8254 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;"); 
			global::android.view.animation.AnimationSet._reset8255 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "reset", "()V"); 
			global::android.view.animation.AnimationSet._initialize8256 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V"); 
			global::android.view.animation.AnimationSet._setStartOffset8257 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V"); 
			global::android.view.animation.AnimationSet._setDuration8258 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V"); 
			global::android.view.animation.AnimationSet._restrictDuration8259 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V"); 
			global::android.view.animation.AnimationSet._scaleCurrentDuration8260 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V"); 
			global::android.view.animation.AnimationSet._setStartTime8261 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V"); 
			global::android.view.animation.AnimationSet._setRepeatMode8262 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V"); 
			global::android.view.animation.AnimationSet._setFillBefore8263 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V"); 
			global::android.view.animation.AnimationSet._setFillAfter8264 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V"); 
			global::android.view.animation.AnimationSet._getStartTime8265 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J"); 
			global::android.view.animation.AnimationSet._getDuration8266 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J"); 
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix8267 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z"); 
			global::android.view.animation.AnimationSet._willChangeBounds8268 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z"); 
			global::android.view.animation.AnimationSet._computeDurationHint8269 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J"); 
			global::android.view.animation.AnimationSet._getTransformation8270 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z"); 
			global::android.view.animation.AnimationSet._addAnimation8271 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.animation.AnimationSet._getAnimations8272 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;"); 
			global::android.view.animation.AnimationSet._AnimationSet8273 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V"); 
			global::android.view.animation.AnimationSet._AnimationSet8274 = @__env.GetMethodID(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
