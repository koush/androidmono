namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class WebIconDatabase : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static WebIconDatabase()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebIconDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.WebIconDatabase(@__env);
			}
		}
		internal WebIconDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface IconListener 
		{
			void onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1);
		}

		public partial class IconListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __IconListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __IconListener : java.lang.Object, IconListener
		{
			internal static global::java.lang.Class staticClass;
			static __IconListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebIconDatabase.__IconListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.webkit.WebIconDatabase.__IconListener(@__env);
				}
			}
			internal __IconListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onReceivedIcon9399;
			 void android.webkit.WebIconDatabase.IconListener.onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase.__IconListener._onReceivedIcon9399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.__IconListener.staticClass, global::android.webkit.WebIconDatabase.__IconListener._onReceivedIcon9399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebIconDatabase.__IconListener.staticClass = @__class;
				global::android.webkit.WebIconDatabase.__IconListener._onReceivedIcon9399 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.__IconListener.staticClass, "android.webkit.WebIconDatabase.IconListener.onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance9400;
		public static global::android.webkit.WebIconDatabase getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebIconDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._getInstance9400));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close9401;
		public void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._close9401);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._close9401);
		}
		internal static global::net.sf.jni4net.jni.MethodId _open9402;
		public void open(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._open9402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._open9402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllIcons9403;
		public void removeAllIcons() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._removeAllIcons9403);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._removeAllIcons9403);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestIconForPageUrl9404;
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._requestIconForPageUrl9404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._requestIconForPageUrl9404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _retainIconForPageUrl9405;
		public void retainIconForPageUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._retainIconForPageUrl9405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._retainIconForPageUrl9405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseIconForPageUrl9406;
		public void releaseIconForPageUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebIconDatabase._releaseIconForPageUrl9406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._releaseIconForPageUrl9406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebIconDatabase.staticClass = @__class;
			global::android.webkit.WebIconDatabase._getInstance9400 = @__env.GetStaticMethodID(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;");
			global::android.webkit.WebIconDatabase._close9401 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "close", "()V");
			global::android.webkit.WebIconDatabase._open9402 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._removeAllIcons9403 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V");
			global::android.webkit.WebIconDatabase._requestIconForPageUrl9404 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.webkit.WebIconDatabase._retainIconForPageUrl9405 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._releaseIconForPageUrl9406 = @__env.GetMethodID(global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V");
		}
	}
}
