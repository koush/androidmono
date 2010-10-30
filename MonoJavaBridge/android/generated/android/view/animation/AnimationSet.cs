namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationSet : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnimationSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::android.view.animation.AnimationSet clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.AnimationSet.staticClass, "clone", "()Landroid/view/animation/AnimationSet;", ref global::android.view.animation.AnimationSet._m0) as android.view.animation.AnimationSet;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "reset", "()V", ref global::android.view.animation.AnimationSet._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "initialize", "(IIII)V", ref global::android.view.animation.AnimationSet._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new long StartOffset
		{
			set
			{
				setStartOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setStartOffset(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setStartOffset", "(J)V", ref global::android.view.animation.AnimationSet._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setDuration", "(J)V", ref global::android.view.animation.AnimationSet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void restrictDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "restrictDuration", "(J)V", ref global::android.view.animation.AnimationSet._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void scaleCurrentDuration(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "scaleCurrentDuration", "(F)V", ref global::android.view.animation.AnimationSet._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setStartTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setStartTime", "(J)V", ref global::android.view.animation.AnimationSet._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RepeatMode
		{
			set
			{
				setRepeatMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setRepeatMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setRepeatMode", "(I)V", ref global::android.view.animation.AnimationSet._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FillBefore
		{
			set
			{
				setFillBefore(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setFillBefore(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setFillBefore", "(Z)V", ref global::android.view.animation.AnimationSet._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FillAfter
		{
			set
			{
				setFillAfter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setFillAfter(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "setFillAfter", "(Z)V", ref global::android.view.animation.AnimationSet._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public override long getStartTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.AnimationSet.staticClass, "getStartTime", "()J", ref global::android.view.animation.AnimationSet._m11);
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
		private static global::MonoJavaBridge.MethodId _m12;
		public override long getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.AnimationSet.staticClass, "getDuration", "()J", ref global::android.view.animation.AnimationSet._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool willChangeTransformationMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, "willChangeTransformationMatrix", "()Z", ref global::android.view.animation.AnimationSet._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool willChangeBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, "willChangeBounds", "()Z", ref global::android.view.animation.AnimationSet._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override long computeDurationHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.AnimationSet.staticClass, "computeDurationHint", "()J", ref global::android.view.animation.AnimationSet._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool getTransformation(long arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AnimationSet.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z", ref global::android.view.animation.AnimationSet._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void addAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AnimationSet.staticClass, "addAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.AnimationSet._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Animations
		{
			get
			{
				return getAnimations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.List getAnimations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.animation.AnimationSet.staticClass, "getAnimations", "()Ljava/util/List;", ref global::android.view.animation.AnimationSet._m18) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public AnimationSet(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationSet._m19.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationSet._m19 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public AnimationSet(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationSet._m20.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationSet._m20 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationSet.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationSet.staticClass, global::android.view.animation.AnimationSet._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AnimationSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
