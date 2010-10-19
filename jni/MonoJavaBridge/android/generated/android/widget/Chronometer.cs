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
			internal static global::MonoJavaBridge.MethodId _onChronometerTick11620;
			 void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer$OnChronometerTickListener"));
				global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick11620 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, "onChronometerTick", "(Landroid/widget/Chronometer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start11621;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._start11621);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._start11621);
		}
		internal static global::MonoJavaBridge.MethodId _stop11622;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._stop11622);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._stop11622);
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
		internal static global::MonoJavaBridge.MethodId _getFormat11623;
		public virtual global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getFormat11623)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getFormat11623)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11624;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onDetachedFromWindow11624);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onDetachedFromWindow11624);
		}
		internal static global::MonoJavaBridge.MethodId _setFormat11625;
		public virtual void setFormat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setFormat11625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setFormat11625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged11626;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._onWindowVisibilityChanged11626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onWindowVisibilityChanged11626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBase11627;
		public virtual void setBase(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setBase11627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setBase11627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBase11628;
		public virtual long getBase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.Chronometer._getBase11628);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getBase11628);
		}
		internal static global::MonoJavaBridge.MethodId _setOnChronometerTickListener11629;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Chronometer._setOnChronometerTickListener11629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setOnChronometerTickListener11629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnChronometerTickListener11630;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Chronometer._getOnChronometerTickListener11630)) as android.widget.Chronometer.OnChronometerTickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Chronometer.OnChronometerTickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getOnChronometerTickListener11630)) as android.widget.Chronometer.OnChronometerTickListener;
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11631;
		public Chronometer(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11632;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer11633;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer11633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Chronometer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer"));
			global::android.widget.Chronometer._start11621 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "start", "()V");
			global::android.widget.Chronometer._stop11622 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "stop", "()V");
			global::android.widget.Chronometer._getFormat11623 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;");
			global::android.widget.Chronometer._onDetachedFromWindow11624 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Chronometer._setFormat11625 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V");
			global::android.widget.Chronometer._onWindowVisibilityChanged11626 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.Chronometer._setBase11627 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setBase", "(J)V");
			global::android.widget.Chronometer._getBase11628 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getBase", "()J");
			global::android.widget.Chronometer._setOnChronometerTickListener11629 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V");
			global::android.widget.Chronometer._getOnChronometerTickListener11630 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
			global::android.widget.Chronometer._Chronometer11631 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Chronometer._Chronometer11632 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Chronometer._Chronometer11633 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
