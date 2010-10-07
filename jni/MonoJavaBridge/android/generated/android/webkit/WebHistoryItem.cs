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
		internal static global::net.sf.jni4net.jni.MethodId _clone10073;
		protected virtual global::android.webkit.WebHistoryItem clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._clone10073));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebHistoryItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._clone10073));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId10074;
		public virtual int getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebHistoryItem._getId10074);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getId10074);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle10075;
		public virtual global::java.lang.String getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getTitle10075));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getTitle10075));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUrl10076;
		public virtual global::java.lang.String getUrl() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getUrl10076));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getUrl10076));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl10077;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getOriginalUrl10077));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getOriginalUrl10077));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon10078;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebHistoryItem._getFavicon10078));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getFavicon10078));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebHistoryItem.staticClass = @__class;
			global::android.webkit.WebHistoryItem._clone10073 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebHistoryItem._getId10074 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I");
			global::android.webkit.WebHistoryItem._getTitle10075 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getUrl10076 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getOriginalUrl10077 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getFavicon10078 = @__env.GetMethodID(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
		}
	}
}
