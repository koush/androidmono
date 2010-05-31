namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebBackForwardList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebBackForwardList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clone9364; 
		protected virtual global::android.webkit.WebBackForwardList clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._clone9364)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._clone9364)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSize9365; 
		public virtual int getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.webkit.WebBackForwardList._getSize9365); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getSize9365); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItem9366; 
		public virtual global::android.webkit.WebHistoryItem getCurrentItem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._getCurrentItem9366)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentItem9366)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentIndex9367; 
		public virtual int getCurrentIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.webkit.WebBackForwardList._getCurrentIndex9367); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentIndex9367); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtIndex9368; 
		public virtual global::android.webkit.WebHistoryItem getItemAtIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebBackForwardList._getItemAtIndex9368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getItemAtIndex9368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebBackForwardList.staticClass = @__class; 
			global::android.webkit.WebBackForwardList._clone9364 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebBackForwardList._getSize9365 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I"); 
			global::android.webkit.WebBackForwardList._getCurrentItem9366 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;"); 
			global::android.webkit.WebBackForwardList._getCurrentIndex9367 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I"); 
			global::android.webkit.WebBackForwardList._getItemAtIndex9368 = @__env.GetMethodID(global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;"); 
		} 
	} 
} 
