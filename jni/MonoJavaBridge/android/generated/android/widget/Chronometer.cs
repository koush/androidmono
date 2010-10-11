namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Chronometer : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Chronometer()
		{
			InitJNI();
		}
		protected Chronometer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Chronometer.OnChronometerTickListener_))]
		public interface OnChronometerTickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onChronometerTick(android.widget.Chronometer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Chronometer.OnChronometerTickListener))]
		public sealed partial class OnChronometerTickListener_ : java.lang.Object, OnChronometerTickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnChronometerTickListener_()
			{
				InitJNI();
			}
			internal OnChronometerTickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChronometerTick11074;
			 void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer$OnChronometerTickListener"));
				global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11074 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, "onChronometerTick", "(Landroid/widget/Chronometer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start11075;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._start11075);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._start11075);
		}
		internal static global::MonoJavaBridge.MethodId _stop11076;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._stop11076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._stop11076);
		}
		internal static global::MonoJavaBridge.MethodId _getFormat11077;
		public virtual global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getFormat11077)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getFormat11077)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11078;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onDetachedFromWindow11078);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onDetachedFromWindow11078);
		}
		internal static global::MonoJavaBridge.MethodId _setFormat11079;
		public virtual void setFormat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setFormat11079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setFormat11079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged11080;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onWindowVisibilityChanged11080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onWindowVisibilityChanged11080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBase11081;
		public virtual void setBase(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setBase11081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setBase11081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBase11082;
		public virtual long getBase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.Chronometer._getBase11082);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getBase11082);
		}
		internal static global::MonoJavaBridge.MethodId _setOnChronometerTickListener11083;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setOnChronometerTickListener11083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setOnChronometerTickListener11083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnChronometerTickListener11084;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getOnChronometerTickListener11084)) as android.widget.Chronometer.OnChronometerTickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getOnChronometerTickListener11084)) as android.widget.Chronometer.OnChronometerTickListener;
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11085;
		public Chronometer(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11086;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11087;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Chronometer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer"));
			global::android.widget.Chronometer._start11075 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "start", "()V");
			global::android.widget.Chronometer._stop11076 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "stop", "()V");
			global::android.widget.Chronometer._getFormat11077 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;");
			global::android.widget.Chronometer._onDetachedFromWindow11078 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Chronometer._setFormat11079 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V");
			global::android.widget.Chronometer._onWindowVisibilityChanged11080 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.Chronometer._setBase11081 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setBase", "(J)V");
			global::android.widget.Chronometer._getBase11082 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getBase", "()J");
			global::android.widget.Chronometer._setOnChronometerTickListener11083 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V");
			global::android.widget.Chronometer._getOnChronometerTickListener11084 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
			global::android.widget.Chronometer._Chronometer11085 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Chronometer._Chronometer11086 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Chronometer._Chronometer11087 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
