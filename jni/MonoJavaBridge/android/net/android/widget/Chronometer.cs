namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Chronometer : android.widget.TextView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Chronometer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Chronometer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _start9286; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _start9286); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _start9286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop9287; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _stop9287); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _stop9287); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFormat9288; 
		public virtual java.lang.String getFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFormat9288)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Chronometer.staticClass, _getFormat9288)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9289; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow9289); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _onDetachedFromWindow9289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFormat9290; 
		public virtual void setFormat(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _setFormat9290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _setFormat9290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged9291; 
		protected override void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _onWindowVisibilityChanged9291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _onWindowVisibilityChanged9291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBase9292; 
		public virtual void setBase(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _setBase9292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _setBase9292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBase9293; 
		public virtual long getBase() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				return @__env.CallLongMethod(this, _getBase9293); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.Chronometer.staticClass, _getBase9293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnChronometerTickListener9294; 
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				@__env.CallVoidMethod(this, _setOnChronometerTickListener9294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Chronometer.staticClass, _setOnChronometerTickListener9294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnChronometerTickListener9295; 
		public virtual android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Chronometer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Chronometer.OnChronometerTickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnChronometerTickListener9295)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Chronometer.OnChronometerTickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Chronometer.staticClass, _getOnChronometerTickListener9295)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer9296; 
		public Chronometer(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Chronometer.staticClass, _Chronometer9296, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer9297; 
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Chronometer.staticClass, _Chronometer9297, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Chronometer9298; 
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Chronometer.staticClass, _Chronometer9298, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Chronometer.staticClass = @__class; 
			global::android.widget.Chronometer._start9286 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "start", "()V"); 
			global::android.widget.Chronometer._stop9287 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "stop", "()V"); 
			global::android.widget.Chronometer._getFormat9288 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;"); 
			global::android.widget.Chronometer._onDetachedFromWindow9289 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.Chronometer._setFormat9290 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V"); 
			global::android.widget.Chronometer._onWindowVisibilityChanged9291 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.widget.Chronometer._setBase9292 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setBase", "(J)V"); 
			global::android.widget.Chronometer._getBase9293 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getBase", "()J"); 
			global::android.widget.Chronometer._setOnChronometerTickListener9294 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V"); 
			global::android.widget.Chronometer._getOnChronometerTickListener9295 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;"); 
			global::android.widget.Chronometer._Chronometer9296 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.Chronometer._Chronometer9297 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.Chronometer._Chronometer9298 = @__env.GetMethodID(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
