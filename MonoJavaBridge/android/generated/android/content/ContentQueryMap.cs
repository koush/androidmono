namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentQueryMap : java.util.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentQueryMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2706;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentQueryMap.staticClass, "finalize", "()V", ref global::android.content.ContentQueryMap._finalize2706);
		}
		internal static global::MonoJavaBridge.MethodId _close2707;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentQueryMap.staticClass, "close", "()V", ref global::android.content.ContentQueryMap._close2707);
		}
		internal static global::MonoJavaBridge.MethodId _requery2708;
		public virtual void requery()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentQueryMap.staticClass, "requery", "()V", ref global::android.content.ContentQueryMap._requery2708);
		}
		public new bool KeepUpdated
		{
			set
			{
				setKeepUpdated(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setKeepUpdated2709;
		public virtual void setKeepUpdated(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentQueryMap.staticClass, "setKeepUpdated", "(Z)V", ref global::android.content.ContentQueryMap._setKeepUpdated2709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValues2710;
		public virtual global::android.content.ContentValues getValues(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ContentValues>(this, global::android.content.ContentQueryMap.staticClass, "getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;", ref global::android.content.ContentQueryMap._getValues2710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentValues;
		}
		public new global::java.util.Map Rows
		{
			get
			{
				return getRows();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRows2711;
		public virtual global::java.util.Map getRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.content.ContentQueryMap.staticClass, "getRows", "()Ljava/util/Map;", ref global::android.content.ContentQueryMap._getRows2711) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _ContentQueryMap2712;
		public ContentQueryMap(android.database.Cursor arg0, java.lang.String arg1, bool arg2, android.os.Handler arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentQueryMap._ContentQueryMap2712.native == global::System.IntPtr.Zero)
				global::android.content.ContentQueryMap._ContentQueryMap2712 = @__env.GetMethodIDNoThrow(global::android.content.ContentQueryMap.staticClass, "<init>", "(Landroid/database/Cursor;Ljava/lang/String;ZLandroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentQueryMap.staticClass, global::android.content.ContentQueryMap._ContentQueryMap2712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ContentQueryMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentQueryMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentQueryMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
