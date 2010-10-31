namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.animation.Animation_))]
	public abstract partial class Animation : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Animation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.animation.Animation.AnimationListener_))]
		public partial interface AnimationListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAnimationStart(android.view.animation.Animation arg0);
			void onAnimationEnd(android.view.animation.Animation arg0);
			void onAnimationRepeat(android.view.animation.Animation arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation.AnimationListener))]
		internal sealed partial class AnimationListener_ : java.lang.Object, AnimationListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AnimationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static AnimationListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class Description : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Description(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected Description() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.animation.Animation.Description._m0.native == global::System.IntPtr.Zero)
					global::android.view.animation.Animation.Description._m0 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type5876;
			public int type
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _type5876);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _value5877;
			public float value
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _value5877);
				}
				set
				{
				}
			}
			static Description()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$Description"));
				global::android.view.animation.Animation.Description._type5876 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "type", "I");
				global::android.view.animation.Animation.Description._value5877 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "value", "F");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::android.view.animation.Animation clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;", ref global::android.view.animation.Animation._m0) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "start", "()V", ref global::android.view.animation.Animation._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "reset", "()V", ref global::android.view.animation.Animation._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V", ref global::android.view.animation.Animation._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "cancel", "()V", ref global::android.view.animation.Animation._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F", ref global::android.view.animation.Animation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getRepeatCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I", ref global::android.view.animation.Animation._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V", ref global::android.view.animation.Animation._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V", ref global::android.view.animation.Animation._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Interpolator>(this, global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;", ref global::android.view.animation.Animation._m9) as android.view.animation.Interpolator;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isInitialized()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "isInitialized", "()Z", ref global::android.view.animation.Animation._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setStartOffset(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V", ref global::android.view.animation.Animation._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setDuration", "(J)V", ref global::android.view.animation.Animation._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void restrictDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V", ref global::android.view.animation.Animation._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void scaleCurrentDuration(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V", ref global::android.view.animation.Animation._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setStartTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V", ref global::android.view.animation.Animation._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void startNow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "startNow", "()V", ref global::android.view.animation.Animation._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setRepeatMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V", ref global::android.view.animation.Animation._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setRepeatCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V", ref global::android.view.animation.Animation._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isFillEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z", ref global::android.view.animation.Animation._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setFillEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V", ref global::android.view.animation.Animation._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setFillBefore(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V", ref global::android.view.animation.Animation._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setFillAfter(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V", ref global::android.view.animation.Animation._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setZAdjustment(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V", ref global::android.view.animation.Animation._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setDetachWallpaper(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V", ref global::android.view.animation.Animation._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual long getStartTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getStartTime", "()J", ref global::android.view.animation.Animation._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual long getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getDuration", "()J", ref global::android.view.animation.Animation._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual long getStartOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getStartOffset", "()J", ref global::android.view.animation.Animation._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual int getRepeatMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I", ref global::android.view.animation.Animation._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool getFillBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z", ref global::android.view.animation.Animation._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool getFillAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z", ref global::android.view.animation.Animation._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int getZAdjustment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I", ref global::android.view.animation.Animation._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool getDetachWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z", ref global::android.view.animation.Animation._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool willChangeTransformationMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z", ref global::android.view.animation.Animation._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool willChangeBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z", ref global::android.view.animation.Animation._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", ref global::android.view.animation.Animation._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		protected virtual void ensureInterpolator()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V", ref global::android.view.animation.Animation._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual long computeDurationHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J", ref global::android.view.animation.Animation._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z", ref global::android.view.animation.Animation._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool hasStarted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "hasStarted", "()Z", ref global::android.view.animation.Animation._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual bool hasEnded()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "hasEnded", "()Z", ref global::android.view.animation.Animation._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.Animation._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.Animation._m42.native == global::System.IntPtr.Zero)
				global::android.view.animation.Animation._m42 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public Animation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.Animation._m43.native == global::System.IntPtr.Zero)
				global::android.view.animation.Animation._m43 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._m43);
			Init(@__env, handle);
		}
		public static int INFINITE
		{
			get
			{
				return -1;
			}
		}
		public static int RESTART
		{
			get
			{
				return 1;
			}
		}
		public static int REVERSE
		{
			get
			{
				return 2;
			}
		}
		public static int START_ON_FIRST_FRAME
		{
			get
			{
				return -1;
			}
		}
		public static int ABSOLUTE
		{
			get
			{
				return 0;
			}
		}
		public static int RELATIVE_TO_SELF
		{
			get
			{
				return 1;
			}
		}
		public static int RELATIVE_TO_PARENT
		{
			get
			{
				return 2;
			}
		}
		public static int ZORDER_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int ZORDER_TOP
		{
			get
			{
				return 1;
			}
		}
		public static int ZORDER_BOTTOM
		{
			get
			{
				return -1;
			}
		}
		static Animation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation))]
	internal sealed partial class Animation_ : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Animation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Animation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
		}
	}
}
