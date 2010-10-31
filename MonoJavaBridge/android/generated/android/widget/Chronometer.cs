namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Chronometer : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Chronometer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Chronometer.OnChronometerTickListener_))]
		public partial interface OnChronometerTickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onChronometerTick(android.widget.Chronometer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Chronometer.OnChronometerTickListener))]
		internal sealed partial class OnChronometerTickListener_ : java.lang.Object, OnChronometerTickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnChronometerTickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, "onChronometerTick", "(Landroid/widget/Chronometer;)V", ref global::android.widget.Chronometer.OnChronometerTickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnChronometerTickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer$OnChronometerTickListener"));
			}
		}

		public delegate void OnChronometerTickListenerDelegate(android.widget.Chronometer arg0);

		internal partial class OnChronometerTickListenerDelegateWrapper : java.lang.Object, OnChronometerTickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnChronometerTickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnChronometerTickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass, global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnChronometerTickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer_OnChronometerTickListenerDelegateWrapper"));
			}
		}
		internal partial class OnChronometerTickListenerDelegateWrapper
		{
			private OnChronometerTickListenerDelegate myDelegate;
			public void onChronometerTick(android.widget.Chronometer arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnChronometerTickListenerDelegateWrapper(OnChronometerTickListenerDelegate d)
			{
				global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper ret = new global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "start", "()V", ref global::android.widget.Chronometer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "stop", "()V", ref global::android.widget.Chronometer._m1);
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
			set
			{
				setFormat(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;", ref global::android.widget.Chronometer._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.Chronometer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setFormat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V", ref global::android.widget.Chronometer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.widget.Chronometer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setBase(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setBase", "(J)V", ref global::android.widget.Chronometer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Base
		{
			get
			{
				return getBase();
			}
			set
			{
				setBase(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long getBase()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.Chronometer.staticClass, "getBase", "()J", ref global::android.widget.Chronometer._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", ref global::android.widget.Chronometer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnChronometerTickListener(global::android.widget.Chronometer.OnChronometerTickListenerDelegate arg0)
		{
			setOnChronometerTickListener((global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Chronometer.OnChronometerTickListener>(this, global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;", ref global::android.widget.Chronometer._m9) as android.widget.Chronometer.OnChronometerTickListener;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Chronometer(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._m10.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._m10 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._m11.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._m11 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._m12.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._m12 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Chronometer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Chronometer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer"));
		}
	}
}
