namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebHistoryItem : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebHistoryItem() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebHistoryItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebHistoryItem(@__env); 
			} 
		} 
		protected WebHistoryItem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone8702; 
		protected virtual android.webkit.WebHistoryItem clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, _clone8702)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebHistoryItem.staticClass, _clone8702)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId8703; 
		public virtual int getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return @__env.CallIntMethod(this, _getId8703); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebHistoryItem.staticClass, _getId8703); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle8704; 
		public virtual java.lang.String getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTitle8704)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebHistoryItem.staticClass, _getTitle8704)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl8705; 
		public virtual java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUrl8705)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebHistoryItem.staticClass, _getUrl8705)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl8706; 
		public virtual java.lang.String getOriginalUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOriginalUrl8706)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebHistoryItem.staticClass, _getOriginalUrl8706)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon8707; 
		public virtual android.graphics.Bitmap getFavicon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getFavicon8707)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebHistoryItem.staticClass, _getFavicon8707)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebHistoryItem.staticClass = @__class; 
			global::android.webkit.WebHistoryItem._clone8702 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;"); 
			global::android.webkit.WebHistoryItem._getId8703 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I"); 
			global::android.webkit.WebHistoryItem._getTitle8704 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getUrl8705 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getOriginalUrl8706 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getFavicon8707 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;"); 
		} 
	} 
} 
