namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.LayoutInflater_))]
	public abstract partial class LayoutInflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayoutInflater()
		{
			InitJNI();
		}
		protected LayoutInflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.LayoutInflater.Factory_))]
		public interface Factory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater.Factory))]
		public sealed partial class Factory_ : java.lang.Object, Factory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Factory_()
			{
				InitJNI();
			}
			internal Factory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreateView9388;
			 global::android.view.View android.view.LayoutInflater.Factory.onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.Factory_._onCreateView9388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.Factory_.staticClass, global::android.view.LayoutInflater.Factory_._onCreateView9388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Factory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Factory"));
				global::android.view.LayoutInflater.Factory_._onCreateView9388 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.Factory_.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.LayoutInflater.Filter_))]
		public interface Filter  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLoadClass(java.lang.Class arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater.Filter))]
		public sealed partial class Filter_ : java.lang.Object, Filter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Filter_()
			{
				InitJNI();
			}
			internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLoadClass9389;
			 bool android.view.LayoutInflater.Filter.onLoadClass(java.lang.Class arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.LayoutInflater.Filter_._onLoadClass9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.LayoutInflater.Filter_.staticClass, global::android.view.LayoutInflater.Filter_._onLoadClass9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Filter"));
				global::android.view.LayoutInflater.Filter_._onLoadClass9389 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.Filter_.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _from9390;
		public static global::android.view.LayoutInflater from(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._from9390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _getFactory9391;
		public virtual global::android.view.LayoutInflater.Factory getFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Factory>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getFactory9391)) as android.view.LayoutInflater.Factory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Factory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFactory9391)) as android.view.LayoutInflater.Factory;
		}
		internal static global::MonoJavaBridge.MethodId _getContext9392;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getContext9392)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getContext9392)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9393;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9394;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9395;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate9395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate9395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9396;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate9396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate9396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView9397;
		protected virtual global::android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._onCreateView9397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._onCreateView9397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _cloneInContext9398;
		public abstract global::android.view.LayoutInflater cloneInContext(android.content.Context arg0);
		internal static global::MonoJavaBridge.MethodId _setFactory9399;
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.LayoutInflater._setFactory9399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFactory9399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter9400;
		public virtual global::android.view.LayoutInflater.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Filter>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getFilter9400)) as android.view.LayoutInflater.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Filter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFilter9400)) as android.view.LayoutInflater.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter9401;
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.LayoutInflater._setFilter9401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFilter9401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createView9402;
		public virtual global::android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._createView9402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._createView9402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _LayoutInflater9403;
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater9403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutInflater9404;
		protected LayoutInflater(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater9404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
			global::android.view.LayoutInflater._from9390 = @__env.GetStaticMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._getFactory9391 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;");
			global::android.view.LayoutInflater._getContext9392 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.LayoutInflater._inflate9393 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate9394 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate9395 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate9396 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._onCreateView9397 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._cloneInContext9398 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._setFactory9399 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V");
			global::android.view.LayoutInflater._getFilter9400 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;");
			global::android.view.LayoutInflater._setFilter9401 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V");
			global::android.view.LayoutInflater._createView9402 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._LayoutInflater9403 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V");
			global::android.view.LayoutInflater._LayoutInflater9404 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater))]
	public sealed partial class LayoutInflater_ : android.view.LayoutInflater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayoutInflater_()
		{
			InitJNI();
		}
		internal LayoutInflater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cloneInContext9405;
		public override global::android.view.LayoutInflater cloneInContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater_._cloneInContext9405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater_.staticClass, global::android.view.LayoutInflater_._cloneInContext9405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
			global::android.view.LayoutInflater_._cloneInContext9405 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater_.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
		}
	}
}
