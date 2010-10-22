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
			internal static global::MonoJavaBridge.MethodId _onChronometerTick16765;
			 void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick16765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick16765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer$OnChronometerTickListener"));
				global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick16765 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, "onChronometerTick", "(Landroid/widget/Chronometer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start16766;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._start16766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._start16766);
		}
		internal static global::MonoJavaBridge.MethodId _stop16767;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._stop16767);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._stop16767);
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
		internal static global::MonoJavaBridge.MethodId _getFormat16768;
		public virtual global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getFormat16768)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getFormat16768)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16769;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onDetachedFromWindow16769);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onDetachedFromWindow16769);
		}
		internal static global::MonoJavaBridge.MethodId _setFormat16770;
		public virtual void setFormat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setFormat16770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setFormat16770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged16771;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onWindowVisibilityChanged16771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onWindowVisibilityChanged16771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBase16772;
		public virtual void setBase(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setBase16772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setBase16772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBase16773;
		public virtual long getBase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.Chronometer._getBase16773);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getBase16773);
		}
		internal static global::MonoJavaBridge.MethodId _setOnChronometerTickListener16774;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setOnChronometerTickListener16774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setOnChronometerTickListener16774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnChronometerTickListener16775;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getOnChronometerTickListener16775)) as android.widget.Chronometer.OnChronometerTickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getOnChronometerTickListener16775)) as android.widget.Chronometer.OnChronometerTickListener;
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16776;
		public Chronometer(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16777;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16778;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Chronometer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer"));
			global::android.widget.Chronometer._start16766 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "start", "()V");
			global::android.widget.Chronometer._stop16767 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "stop", "()V");
			global::android.widget.Chronometer._getFormat16768 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;");
			global::android.widget.Chronometer._onDetachedFromWindow16769 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Chronometer._setFormat16770 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V");
			global::android.widget.Chronometer._onWindowVisibilityChanged16771 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.Chronometer._setBase16772 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setBase", "(J)V");
			global::android.widget.Chronometer._getBase16773 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getBase", "()J");
			global::android.widget.Chronometer._setOnChronometerTickListener16774 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V");
			global::android.widget.Chronometer._getOnChronometerTickListener16775 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
			global::android.widget.Chronometer._Chronometer16776 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Chronometer._Chronometer16777 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Chronometer._Chronometer16778 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
