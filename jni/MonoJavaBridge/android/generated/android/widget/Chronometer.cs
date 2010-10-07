namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Chronometer : android.widget.TextView
	{
		internal new static global::java.lang.Class staticClass;
		static Chronometer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Chronometer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.Chronometer(@__env);
			}
		}
		protected Chronometer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnChronometerTickListener 
		{
			void onChronometerTick(android.widget.Chronometer arg0);
		}

		public partial class OnChronometerTickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnChronometerTickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnChronometerTickListener : java.lang.Object, OnChronometerTickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnChronometerTickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Chronometer.__OnChronometerTickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.Chronometer.__OnChronometerTickListener(@__env);
				}
			}
			internal __OnChronometerTickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChronometerTick10704;
			 void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.Chronometer.__OnChronometerTickListener._onChronometerTick10704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.__OnChronometerTickListener.staticClass, global::android.widget.Chronometer.__OnChronometerTickListener._onChronometerTick10704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.Chronometer.__OnChronometerTickListener.staticClass = @__class;
				global::android.widget.Chronometer.__OnChronometerTickListener._onChronometerTick10704 = @__env.GetMethodID(global::android.widget.Chronometer.__OnChronometerTickListener.staticClass, "android.widget.Chronometer.OnChronometerTickListener.onChronometerTick", "(Landroid/widget/Chronometer;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _start10705;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._start10705);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._start10705);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop10706;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._stop10706);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._stop10706);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFormat10707;
		public virtual global::java.lang.String getFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Chronometer._getFormat10707));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getFormat10707));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10708;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._onDetachedFromWindow10708);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onDetachedFromWindow10708);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFormat10709;
		public virtual void setFormat(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._setFormat10709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setFormat10709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged10710;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._onWindowVisibilityChanged10710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._onWindowVisibilityChanged10710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBase10711;
		public virtual void setBase(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._setBase10711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setBase10711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBase10712;
		public virtual long getBase() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.Chronometer._getBase10712);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getBase10712);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnChronometerTickListener10713;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Chronometer._setOnChronometerTickListener10713, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._setOnChronometerTickListener10713, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnChronometerTickListener10714;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Chronometer.OnChronometerTickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Chronometer._getOnChronometerTickListener10714));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Chronometer.OnChronometerTickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Chronometer.staticClass, global::android.widget.Chronometer._getOnChronometerTickListener10714));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer10715;
		public Chronometer(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer10715, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer10716;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer10716, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer10717;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer10717, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.Chronometer.staticClass = @__class;
			global::android.widget.Chronometer._start10705 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "start", "()V");
			global::android.widget.Chronometer._stop10706 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "stop", "()V");
			global::android.widget.Chronometer._getFormat10707 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;");
			global::android.widget.Chronometer._onDetachedFromWindow10708 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Chronometer._setFormat10709 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V");
			global::android.widget.Chronometer._onWindowVisibilityChanged10710 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.Chronometer._setBase10711 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setBase", "(J)V");
			global::android.widget.Chronometer._getBase10712 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getBase", "()J");
			global::android.widget.Chronometer._setOnChronometerTickListener10713 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V");
			global::android.widget.Chronometer._getOnChronometerTickListener10714 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
			global::android.widget.Chronometer._Chronometer10715 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Chronometer._Chronometer10716 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Chronometer._Chronometer10717 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
