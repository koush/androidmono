namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationSet : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnimationSet()
		{
			InitJNI();
		}
		protected AnimationSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone15555;
		protected virtual global::android.view.animation.AnimationSet clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._clone15555)) as android.view.animation.AnimationSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._clone15555)) as android.view.animation.AnimationSet;
		}
		internal static global::MonoJavaBridge.MethodId _reset15556;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._reset15556);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._reset15556);
		}
		internal static global::MonoJavaBridge.MethodId _initialize15557;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._initialize15557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._initialize15557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset15558;
		public override void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartOffset15558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartOffset15558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration15559;
		public override void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setDuration15559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setDuration15559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration15560;
		public override void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._restrictDuration15560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._restrictDuration15560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration15561;
		public override void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._scaleCurrentDuration15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._scaleCurrentDuration15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime15562;
		public override void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartTime15562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartTime15562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode15563;
		public override void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setRepeatMode15563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setRepeatMode15563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore15564;
		public override void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillBefore15564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillBefore15564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter15565;
		public override void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillAfter15565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillAfter15565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long StartTime
		{
			get
			{
				return getStartTime();
			}
			set
			{
				setStartTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime15566;
		public override long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getStartTime15566);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getStartTime15566);
		}
		public new long Duration
		{
			get
			{
				return getDuration();
			}
			set
			{
				setDuration(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration15567;
		public override long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getDuration15567);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getDuration15567);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15568;
		public override bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeTransformationMatrix15568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeTransformationMatrix15568);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15569;
		public override bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeBounds15569);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeBounds15569);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint15570;
		public override long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._computeDurationHint15570);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._computeDurationHint15570);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation15571;
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getTransformation15571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getTransformation15571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAnimation15572;
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._addAnimation15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._addAnimation15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Animations
		{
			get
			{
				return getAnimations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimations15573;
		public virtual global::java.util.List getAnimations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getAnimations15573)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getAnimations15573)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet15574;
		public AnimationSet(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet15574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet15575;
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet15575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationSet"));
			global::android.view.animation.AnimationSet._clone15555 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;");
			global::android.view.animation.AnimationSet._reset15556 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "reset", "()V");
			global::android.view.animation.AnimationSet._initialize15557 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.AnimationSet._setStartOffset15558 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.AnimationSet._setDuration15559 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V");
			global::android.view.animation.AnimationSet._restrictDuration15560 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.AnimationSet._scaleCurrentDuration15561 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.AnimationSet._setStartTime15562 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.AnimationSet._setRepeatMode15563 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.AnimationSet._setFillBefore15564 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.AnimationSet._setFillAfter15565 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.AnimationSet._getStartTime15566 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J");
			global::android.view.animation.AnimationSet._getDuration15567 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J");
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix15568 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AnimationSet._willChangeBounds15569 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AnimationSet._computeDurationHint15570 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.AnimationSet._getTransformation15571 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.AnimationSet._addAnimation15572 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.AnimationSet._getAnimations15573 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;");
			global::android.view.animation.AnimationSet._AnimationSet15574 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V");
			global::android.view.animation.AnimationSet._AnimationSet15575 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
