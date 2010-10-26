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
		internal static global::MonoJavaBridge.MethodId _clone15635;
		protected virtual global::android.view.animation.AnimationSet clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._clone15635)) as android.view.animation.AnimationSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._clone15635)) as android.view.animation.AnimationSet;
		}
		internal static global::MonoJavaBridge.MethodId _reset15636;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._reset15636);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._reset15636);
		}
		internal static global::MonoJavaBridge.MethodId _initialize15637;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._initialize15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._initialize15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset15638;
		public override void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartOffset15638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartOffset15638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration15639;
		public override void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setDuration15639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setDuration15639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration15640;
		public override void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._restrictDuration15640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._restrictDuration15640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration15641;
		public override void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._scaleCurrentDuration15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._scaleCurrentDuration15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime15642;
		public override void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartTime15642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartTime15642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode15643;
		public override void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setRepeatMode15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setRepeatMode15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore15644;
		public override void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillBefore15644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillBefore15644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter15645;
		public override void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillAfter15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillAfter15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStartTime15646;
		public override long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getStartTime15646);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getStartTime15646);
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
		internal static global::MonoJavaBridge.MethodId _getDuration15647;
		public override long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getDuration15647);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getDuration15647);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15648;
		public override bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeTransformationMatrix15648);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeTransformationMatrix15648);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15649;
		public override bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeBounds15649);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeBounds15649);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint15650;
		public override long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._computeDurationHint15650);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._computeDurationHint15650);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation15651;
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getTransformation15651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getTransformation15651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAnimation15652;
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._addAnimation15652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._addAnimation15652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Animations
		{
			get
			{
				return getAnimations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimations15653;
		public virtual global::java.util.List getAnimations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getAnimations15653)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getAnimations15653)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet15654;
		public AnimationSet(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet15654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet15655;
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet15655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationSet"));
			global::android.view.animation.AnimationSet._clone15635 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;");
			global::android.view.animation.AnimationSet._reset15636 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "reset", "()V");
			global::android.view.animation.AnimationSet._initialize15637 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.AnimationSet._setStartOffset15638 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.AnimationSet._setDuration15639 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V");
			global::android.view.animation.AnimationSet._restrictDuration15640 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.AnimationSet._scaleCurrentDuration15641 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.AnimationSet._setStartTime15642 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.AnimationSet._setRepeatMode15643 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.AnimationSet._setFillBefore15644 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.AnimationSet._setFillAfter15645 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.AnimationSet._getStartTime15646 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J");
			global::android.view.animation.AnimationSet._getDuration15647 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J");
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix15648 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AnimationSet._willChangeBounds15649 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AnimationSet._computeDurationHint15650 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.AnimationSet._getTransformation15651 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.AnimationSet._addAnimation15652 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.AnimationSet._getAnimations15653 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;");
			global::android.view.animation.AnimationSet._AnimationSet15654 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V");
			global::android.view.animation.AnimationSet._AnimationSet15655 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
