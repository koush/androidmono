namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayoutAnimationController : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LayoutAnimationController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AnimationParameters : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AnimationParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public AnimationParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.animation.LayoutAnimationController.AnimationParameters._m0.native == global::System.IntPtr.Zero)
					global::android.view.animation.LayoutAnimationController.AnimationParameters._m0 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _count5901;
			public int count
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _count5901);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _index5902;
			public int index
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _index5902);
				}
				set
				{
				}
			}
			static AnimationParameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController$AnimationParameters"));
				global::android.view.animation.LayoutAnimationController.AnimationParameters._count5901 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "count", "I");
				global::android.view.animation.LayoutAnimationController.AnimationParameters._index5902 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "index", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V", ref global::android.view.animation.LayoutAnimationController._m0);
		}
		public new global::android.view.animation.Animation Animation
		{
			get
			{
				return getAnimation();
			}
			set
			{
				setAnimation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.animation.Animation getAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;", ref global::android.view.animation.LayoutAnimationController._m1) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V", ref global::android.view.animation.LayoutAnimationController._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.LayoutAnimationController._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Order
		{
			get
			{
				return getOrder();
			}
			set
			{
				setOrder(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getOrder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I", ref global::android.view.animation.LayoutAnimationController._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z", ref global::android.view.animation.LayoutAnimationController._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setOrder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V", ref global::android.view.animation.LayoutAnimationController._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V", ref global::android.view.animation.LayoutAnimationController._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V", ref global::android.view.animation.LayoutAnimationController._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.animation.InterpolatorDelegate Interpolator
		{
			get
			{
				return new global::android.view.animation.InterpolatorDelegate(getInterpolator().getInterpolation);
			}
			set
			{
				setInterpolator(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Interpolator>(this, global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;", ref global::android.view.animation.LayoutAnimationController._m9) as android.view.animation.Interpolator;
		}
		public new float Delay
		{
			get
			{
				return getDelay();
			}
			set
			{
				setDelay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual float getDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F", ref global::android.view.animation.LayoutAnimationController._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V", ref global::android.view.animation.LayoutAnimationController._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool willOverlap()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z", ref global::android.view.animation.LayoutAnimationController._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;", ref global::android.view.animation.LayoutAnimationController._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual long getDelayForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J", ref global::android.view.animation.LayoutAnimationController._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I", ref global::android.view.animation.LayoutAnimationController._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._m16.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._m16 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._m17.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._m17 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public LayoutAnimationController(android.view.animation.Animation arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._m18.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._m18 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int ORDER_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int ORDER_REVERSE
		{
			get
			{
				return 1;
			}
		}
		public static int ORDER_RANDOM
		{
			get
			{
				return 2;
			}
		}
		static LayoutAnimationController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.LayoutAnimationController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController"));
		}
		internal static void InitJNI()
		{
		}
	}
}
