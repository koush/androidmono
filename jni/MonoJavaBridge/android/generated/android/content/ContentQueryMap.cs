namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentQueryMap : java.util.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentQueryMap()
		{
			InitJNI();
		}
		protected ContentQueryMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2698;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap._finalize2698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._finalize2698);
		}
		internal static global::MonoJavaBridge.MethodId _close2699;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap._close2699);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._close2699);
		}
		internal static global::MonoJavaBridge.MethodId _requery2700;
		public virtual void requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap._requery2700);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._requery2700);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepUpdated2701;
		public virtual void setKeepUpdated(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap._setKeepUpdated2701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._setKeepUpdated2701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValues2702;
		public virtual global::android.content.ContentValues getValues(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ContentValues>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentQueryMap._getValues2702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentValues;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ContentValues>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._getValues2702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentValues;
		}
		public new global::java.util.Map Rows
		{
			get
			{
				return getRows();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRows2703;
		public virtual global::java.util.Map getRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentQueryMap._getRows2703)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._getRows2703)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _ContentQueryMap2704;
		public ContentQueryMap(android.database.Cursor arg0, java.lang.String arg1, bool arg2, android.os.Handler arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._ContentQueryMap2704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentQueryMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentQueryMap"));
			global::android.content.ContentQueryMap._finalize2698 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "finalize", "()V");
			global::android.content.ContentQueryMap._close2699 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "close", "()V");
			global::android.content.ContentQueryMap._requery2700 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "requery", "()V");
			global::android.content.ContentQueryMap._setKeepUpdated2701 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "setKeepUpdated", "(Z)V");
			global::android.content.ContentQueryMap._getValues2702 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;");
			global::android.content.ContentQueryMap._getRows2703 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "getRows", "()Ljava/util/Map;");
			global::android.content.ContentQueryMap._ContentQueryMap2704 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "<init>", "(Landroid/database/Cursor;Ljava/lang/String;ZLandroid/os/Handler;)V");
		}
	}
}
