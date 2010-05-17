namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebBackForwardList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebBackForwardList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebBackForwardList(@__env); 
			} 
		} 
		protected WebBackForwardList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone8674; 
		protected virtual android.webkit.WebBackForwardList clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebBackForwardList)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, _clone8674)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebBackForwardList.staticClass, _clone8674)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize8675; 
		public virtual int getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebBackForwardList)) 
				return @__env.CallIntMethod(this, _getSize8675); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebBackForwardList.staticClass, _getSize8675); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItem8676; 
		public virtual android.webkit.WebHistoryItem getCurrentItem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebBackForwardList)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentItem8676)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebBackForwardList.staticClass, _getCurrentItem8676)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentIndex8677; 
		public virtual int getCurrentIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebBackForwardList)) 
				return @__env.CallIntMethod(this, _getCurrentIndex8677); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebBackForwardList.staticClass, _getCurrentIndex8677); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtIndex8678; 
		public virtual android.webkit.WebHistoryItem getItemAtIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebBackForwardList)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, _getItemAtIndex8678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebBackForwardList.staticClass, _getItemAtIndex8678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebBackForwardList.staticClass = @__class; 
			global::android.webkit.WebBackForwardList._clone8674 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebBackForwardList._getSize8675 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I"); 
			global::android.webkit.WebBackForwardList._getCurrentItem8676 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;"); 
			global::android.webkit.WebBackForwardList._getCurrentIndex8677 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I"); 
			global::android.webkit.WebBackForwardList._getItemAtIndex8678 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;"); 
		} 
	} 
} 
