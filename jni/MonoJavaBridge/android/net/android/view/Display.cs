namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Display : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Display() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.Display), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.Display(@__env); 
			} 
		} 
		protected Display(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth7305; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallIntMethod(this, _getWidth7305); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Display.staticClass, _getWidth7305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight7306; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallIntMethod(this, _getHeight7306); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Display.staticClass, _getHeight7306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation7307; 
		public virtual int getOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallIntMethod(this, _getOrientation7307); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Display.staticClass, _getOrientation7307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayId7308; 
		public virtual int getDisplayId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallIntMethod(this, _getDisplayId7308); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Display.staticClass, _getDisplayId7308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixelFormat7309; 
		public virtual int getPixelFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallIntMethod(this, _getPixelFormat7309); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Display.staticClass, _getPixelFormat7309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRefreshRate7310; 
		public virtual float getRefreshRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				return @__env.CallFloatMethod(this, _getRefreshRate7310); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.Display.staticClass, _getRefreshRate7310); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics7311; 
		public virtual void getMetrics(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Display)) 
				@__env.CallVoidMethod(this, _getMetrics7311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Display.staticClass, _getMetrics7311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int DEFAULT_DISPLAY
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.Display.staticClass = @__class; 
			global::android.view.Display._getWidth7305 = @__env.GetMethodID(global::android.view.Display.staticClass, "getWidth", "()I"); 
			global::android.view.Display._getHeight7306 = @__env.GetMethodID(global::android.view.Display.staticClass, "getHeight", "()I"); 
			global::android.view.Display._getOrientation7307 = @__env.GetMethodID(global::android.view.Display.staticClass, "getOrientation", "()I"); 
			global::android.view.Display._getDisplayId7308 = @__env.GetMethodID(global::android.view.Display.staticClass, "getDisplayId", "()I"); 
			global::android.view.Display._getPixelFormat7309 = @__env.GetMethodID(global::android.view.Display.staticClass, "getPixelFormat", "()I"); 
			global::android.view.Display._getRefreshRate7310 = @__env.GetMethodID(global::android.view.Display.staticClass, "getRefreshRate", "()F"); 
			global::android.view.Display._getMetrics7311 = @__env.GetMethodID(global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V"); 
		} 
	} 
} 
