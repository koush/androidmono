namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebHistoryItem : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebHistoryItem() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebHistoryItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clone9393; 
		protected virtual global::android.webkit.WebHistoryItem clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._clone9393)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._clone9393)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId9394; 
		public virtual int getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebHistoryItem._getId9394); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getId9394); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle9395; 
		public virtual global::java.lang.String getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getTitle9395)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getTitle9395)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl9396; 
		public virtual global::java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getUrl9396)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getUrl9396)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl9397; 
		public virtual global::java.lang.String getOriginalUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getOriginalUrl9397)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getOriginalUrl9397)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon9398; 
		public virtual global::android.graphics.Bitmap getFavicon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebHistoryItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getFavicon9398)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getFavicon9398)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebHistoryItem.staticClass = @__class; 
			global::android.webkit.WebHistoryItem._clone9393 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;"); 
			global::android.webkit.WebHistoryItem._getId9394 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I"); 
			global::android.webkit.WebHistoryItem._getTitle9395 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getUrl9396 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getOriginalUrl9397 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebHistoryItem._getFavicon9398 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;"); 
		} 
	} 
} 
