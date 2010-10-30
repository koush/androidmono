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
			internal static global::MonoJavaBridge.MethodId _onRatingChanged17556;
			void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", ref global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged17556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnRatingBarChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar$OnRatingBarChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnRatingBarChangeListenerDelegate(android.widget.RatingBar arg0, float arg1, bool arg2);

		internal partial class OnRatingBarChangeListenerDelegateWrapper : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnRatingBarChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnRatingBarChangeListenerDelegateWrapper17557;
			public OnRatingBarChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._OnRatingBarChangeListenerDelegateWrapper17557.native == global::System.IntPtr.Zero)
					global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._OnRatingBarChangeListenerDelegateWrapper17557 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._OnRatingBarChangeListenerDelegateWrapper17557);
				Init(@__env, handle);
			}
			static OnRatingBarChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar_OnRatingBarChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _isIndicator17558;
		public virtual bool isIndicator()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RatingBar.staticClass, "isIndicator", "()Z", ref global::android.widget.RatingBar._isIndicator17558);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17559;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V", ref global::android.widget.RatingBar._onMeasure17559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Max
		{
			set
			{
				setMax(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMax17560;
		public override void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setMax", "(I)V", ref global::android.widget.RatingBar._setMax17560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnRatingBarChangeListener17561;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V", ref global::android.widget.RatingBar._setOnRatingBarChangeListener17561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnRatingBarChangeListener(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegate arg0)
		{
			setOnRatingBarChangeListener((global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnRatingBarChangeListener17562;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.RatingBar.OnRatingBarChangeListener>(this, global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;", ref global::android.widget.RatingBar._getOnRatingBarChangeListener17562) as android.widget.RatingBar.OnRatingBarChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setIsIndicator17563;
		public virtual void setIsIndicator(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V", ref global::android.widget.RatingBar._setIsIndicator17563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNumStars17564;
		public virtual void setNumStars(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V", ref global::android.widget.RatingBar._setNumStars17564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNumStars17565;
		public virtual int getNumStars()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RatingBar.staticClass, "getNumStars", "()I", ref global::android.widget.RatingBar._getNumStars17565);
		}
		internal static global::MonoJavaBridge.MethodId _setRating17566;
		public virtual void setRating(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setRating", "(F)V", ref global::android.widget.RatingBar._setRating17566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRating17567;
		public virtual float getRating()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.RatingBar.staticClass, "getRating", "()F", ref global::android.widget.RatingBar._getRating17567);
		}
		internal static global::MonoJavaBridge.MethodId _setStepSize17568;
		public virtual void setStepSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V", ref global::android.widget.RatingBar._setStepSize17568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStepSize17569;
		public virtual float getStepSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.RatingBar.staticClass, "getStepSize", "()F", ref global::android.widget.RatingBar._getStepSize17569);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17570;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._RatingBar17570.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._RatingBar17570 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17571;
		public RatingBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._RatingBar17571.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._RatingBar17571 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17572;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RatingBar._RatingBar17572.native == global::System.IntPtr.Zero)
				global::android.widget.RatingBar._RatingBar17572 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RatingBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RatingBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
