namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RatingBar : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RatingBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener_))]
		public partial interface OnRatingBarChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener))]
		internal sealed partial class OnRatingBarChangeListener_ : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnRatingBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", ref global::android.widget.RatingBar.OnRatingBarChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnRatingBarChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar$OnRatingBarChangeListener"));
			}
		}

		public delegate void OnRatingBarChangeListenerDelegate(android.widget.RatingBar arg0, float arg1, bool arg2);

		internal partial class OnRatingBarChangeListenerDelegateWrapper : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnRatingBarChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnRatingBarChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnRatingBarChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar_OnRatingBarChangeListenerDelegateWrapper"));
			}
		}
		internal partial class OnRatingBarChangeListenerDelegateWrapper
		{
			private OnRatingBarChangeListenerDelegate myDelegate;
			public void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnRatingBarChangeListenerDelegateWrapper(OnRatingBarChangeListenerDelegate d)
			{
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper ret = new global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool isIndicator()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RatingBar.staticClass, "isIndicator", "()Z", ref global::android.widget.RatingBar._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V", ref global::android.widget.RatingBar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Max
		{
			set
			{
				setMax(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setMax", "(I)V", ref global::android.widget.RatingBar._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V", ref global::android.widget.RatingBar._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnRatingBarChangeListener(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegate arg0)
		{
			setOnRatingBarChangeListener((global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.RatingBar.OnRatingBarChangeListener>(this, global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;", ref global::android.widget.RatingBar._m4) as android.widget.RatingBar.OnRatingBarChangeListener;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setIsIndicator(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V", ref global::android.widget.RatingBar._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setNumStars(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V", ref global::android.widget.RatingBar._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NumStars
		{
			get
			{
				return getNumStars();
			}
			set
			{
				setNumStars(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getNumStars()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RatingBar.staticClass, "getNumStars", "()I", ref global::android.widget.RatingBar._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setRating(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setRating", "(F)V", ref global::android.widget.RatingBar._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Rating
		{
			get
			{
				return getRating();
			}
			set
			{
				setRating(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual float getRating()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.RatingBar.staticClass, "getRating", "()F", ref global::android.widget.RatingBar._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setStepSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V", ref global::android.widget.RatingBar._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float StepSize
		{
			get
			{
				return getStepSize();
			}
			set
			{
				setStepSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual float getStepSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.RatingBar.staticClass, "getStepSize", "()F", ref global::android.widget.RatingBar._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._m12.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._m12 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public RatingBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._m13.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._m13 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._m14.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._m14 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RatingBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RatingBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar"));
		}
	}
}
