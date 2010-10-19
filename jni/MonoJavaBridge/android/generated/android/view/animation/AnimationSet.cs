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
		internal static global::MonoJavaBridge.MethodId _clone10496;
		protected virtual global::android.view.animation.AnimationSet clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._clone10496)) as android.view.animation.AnimationSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._clone10496)) as android.view.animation.AnimationSet;
		}
		internal static global::MonoJavaBridge.MethodId _reset10497;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._reset10497);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._reset10497);
		}
		internal static global::MonoJavaBridge.MethodId _initialize10498;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._initialize10498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._initialize10498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset10499;
		public override void setStartOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartOffset10499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartOffset10499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration10500;
		public override void setDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setDuration10500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setDuration10500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration10501;
		public override void restrictDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._restrictDuration10501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._restrictDuration10501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration10502;
		public override void scaleCurrentDuration(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._scaleCurrentDuration10502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._scaleCurrentDuration10502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime10503;
		public override void setStartTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setStartTime10503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setStartTime10503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode10504;
		public override void setRepeatMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setRepeatMode10504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setRepeatMode10504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore10505;
		public override void setFillBefore(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillBefore10505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillBefore10505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter10506;
		public override void setFillAfter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._setFillAfter10506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._setFillAfter10506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStartTime10507;
		public override long getStartTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getStartTime10507);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getStartTime10507);
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
		internal static global::MonoJavaBridge.MethodId _getDuration10508;
		public override long getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getDuration10508);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getDuration10508);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix10509;
		public override bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeTransformationMatrix10509);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeTransformationMatrix10509);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds10510;
		public override bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._willChangeBounds10510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._willChangeBounds10510);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint10511;
		public override long computeDurationHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet._computeDurationHint10511);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._computeDurationHint10511);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation10512;
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getTransformation10512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getTransformation10512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addAnimation10513;
		public virtual void addAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet._addAnimation10513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._addAnimation10513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Animations
		{
			get
			{
				return getAnimations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimations10514;
		public virtual global::java.util.List getAnimations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet._getAnimations10514)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._getAnimations10514)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet10515;
		public AnimationSet(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet10515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnimationSet10516;
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._AnimationSet10516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationSet"));
			global::android.view.animation.AnimationSet._clone10496 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;");
			global::android.view.animation.AnimationSet._reset10497 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "reset", "()V");
			global::android.view.animation.AnimationSet._initialize10498 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.AnimationSet._setStartOffset10499 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V");
			global::android.view.animation.AnimationSet._setDuration10500 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V");
			global::android.view.animation.AnimationSet._restrictDuration10501 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V");
			global::android.view.animation.AnimationSet._scaleCurrentDuration10502 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V");
			global::android.view.animation.AnimationSet._setStartTime10503 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V");
			global::android.view.animation.AnimationSet._setRepeatMode10504 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V");
			global::android.view.animation.AnimationSet._setFillBefore10505 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V");
			global::android.view.animation.AnimationSet._setFillAfter10506 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V");
			global::android.view.animation.AnimationSet._getStartTime10507 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J");
			global::android.view.animation.AnimationSet._getDuration10508 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J");
			global::android.view.animation.AnimationSet._willChangeTransformationMatrix10509 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AnimationSet._willChangeBounds10510 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AnimationSet._computeDurationHint10511 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J");
			global::android.view.animation.AnimationSet._getTransformation10512 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z");
			global::android.view.animation.AnimationSet._addAnimation10513 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.AnimationSet._getAnimations10514 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;");
			global::android.view.animation.AnimationSet._AnimationSet10515 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V");
			global::android.view.animation.AnimationSet._AnimationSet10516 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
