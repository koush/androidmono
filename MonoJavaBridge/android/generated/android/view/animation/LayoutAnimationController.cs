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
			internal static global::MonoJavaBridge.MethodId _AnimationParameters15712;
			public AnimationParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters15712.native == global::System.IntPtr.Zero)
					global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters15712 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.LayoutAnimationController.AnimationParameters._AnimationParameters15712);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _count15713;
			public int count
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _count15713);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _index15714;
			public int index
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _index15714);
				}
				set
				{
				}
			}
			static AnimationParameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LayoutAnimationController$AnimationParameters"));
				global::android.view.animation.LayoutAnimationController.AnimationParameters._count15713 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "count", "I");
				global::android.view.animation.LayoutAnimationController.AnimationParameters._index15714 = @__env.GetFieldIDNoThrow(global::android.view.animation.LayoutAnimationController.AnimationParameters.staticClass, "index", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _start15715;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "start", "()V", ref global::android.view.animation.LayoutAnimationController._start15715);
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
		internal static global::MonoJavaBridge.MethodId _getAnimation15716;
		public virtual global::android.view.animation.Animation getAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getAnimation", "()Landroid/view/animation/Animation;", ref global::android.view.animation.LayoutAnimationController._getAnimation15716) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation15717;
		public virtual void setAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/content/Context;I)V", ref global::android.view.animation.LayoutAnimationController._setAnimation15717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation15718;
		public virtual void setAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.LayoutAnimationController._setAnimation15718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrder15719;
		public virtual int getOrder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getOrder", "()I", ref global::android.view.animation.LayoutAnimationController._getOrder15719);
		}
		internal static global::MonoJavaBridge.MethodId _isDone15720;
		public virtual bool isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "isDone", "()Z", ref global::android.view.animation.LayoutAnimationController._isDone15720);
		}
		internal static global::MonoJavaBridge.MethodId _setOrder15721;
		public virtual void setOrder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setOrder", "(I)V", ref global::android.view.animation.LayoutAnimationController._setOrder15721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15722;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V", ref global::android.view.animation.LayoutAnimationController._setInterpolator15722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15723;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setInterpolator", "(Landroid/content/Context;I)V", ref global::android.view.animation.LayoutAnimationController._setInterpolator15723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getInterpolator15724;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Interpolator>(this, global::android.view.animation.LayoutAnimationController.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;", ref global::android.view.animation.LayoutAnimationController._getInterpolator15724) as android.view.animation.Interpolator;
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
		internal static global::MonoJavaBridge.MethodId _getDelay15725;
		public virtual float getDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getDelay", "()F", ref global::android.view.animation.LayoutAnimationController._getDelay15725);
		}
		internal static global::MonoJavaBridge.MethodId _setDelay15726;
		public virtual void setDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "setDelay", "(F)V", ref global::android.view.animation.LayoutAnimationController._setDelay15726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap15727;
		public virtual bool willOverlap()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "willOverlap", "()Z", ref global::android.view.animation.LayoutAnimationController._willOverlap15727);
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationForView15728;
		public virtual global::android.view.animation.Animation getAnimationForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;", ref global::android.view.animation.LayoutAnimationController._getAnimationForView15728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView15729;
		protected virtual long getDelayForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J", ref global::android.view.animation.LayoutAnimationController._getDelayForView15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformedIndex15730;
		protected virtual int getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.LayoutAnimationController.staticClass, "getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I", ref global::android.view.animation.LayoutAnimationController._getTransformedIndex15730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15731;
		public LayoutAnimationController(android.view.animation.Animation arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._LayoutAnimationController15731.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._LayoutAnimationController15731 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15732;
		public LayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._LayoutAnimationController15732.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._LayoutAnimationController15732 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutAnimationController15733;
		public LayoutAnimationController(android.view.animation.Animation arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.LayoutAnimationController._LayoutAnimationController15733.native == global::System.IntPtr.Zero)
				global::android.view.animation.LayoutAnimationController._LayoutAnimationController15733 = @__env.GetMethodIDNoThrow(global::android.view.animation.LayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LayoutAnimationController.staticClass, global::android.view.animation.LayoutAnimationController._LayoutAnimationController15733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
