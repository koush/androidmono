namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DateSorter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DateSorter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.DateSorter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.DateSorter(@__env); 
			} 
		} 
		protected DateSorter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex9281; 
		public virtual int getIndex(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.DateSorter)) 
				return @__env.CallIntMethod(this, _getIndex9281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.DateSorter.staticClass, _getIndex9281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLabel9282; 
		public virtual java.lang.String getLabel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.DateSorter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLabel9282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.DateSorter.staticClass, _getLabel9282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoundary9283; 
		public virtual long getBoundary(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.DateSorter)) 
				return @__env.CallLongMethod(this, _getBoundary9283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.webkit.DateSorter.staticClass, _getBoundary9283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DateSorter9284; 
		public DateSorter(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.DateSorter.staticClass, _DateSorter9284, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int DAY_COUNT
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.DateSorter.staticClass = @__class; 
			global::android.webkit.DateSorter._getIndex9281 = @__env.GetMethodID(global::android.webkit.DateSorter.staticClass, "getIndex", "(J)I"); 
			global::android.webkit.DateSorter._getLabel9282 = @__env.GetMethodID(global::android.webkit.DateSorter.staticClass, "getLabel", "(I)Ljava/lang/String;"); 
			global::android.webkit.DateSorter._getBoundary9283 = @__env.GetMethodID(global::android.webkit.DateSorter.staticClass, "getBoundary", "(I)J"); 
			global::android.webkit.DateSorter._DateSorter9284 = @__env.GetMethodID(global::android.webkit.DateSorter.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
