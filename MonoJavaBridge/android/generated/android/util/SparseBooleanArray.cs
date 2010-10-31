namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseBooleanArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseBooleanArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z", ref global::android.util.SparseBooleanArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool get(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z", ref global::android.util.SparseBooleanArray._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void put(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V", ref global::android.util.SparseBooleanArray._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void append(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V", ref global::android.util.SparseBooleanArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, "clear", "()V", ref global::android.util.SparseBooleanArray._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, "size", "()I", ref global::android.util.SparseBooleanArray._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V", ref global::android.util.SparseBooleanArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int keyAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I", ref global::android.util.SparseBooleanArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool valueAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z", ref global::android.util.SparseBooleanArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int indexOfKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I", ref global::android.util.SparseBooleanArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int indexOfValue(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I", ref global::android.util.SparseBooleanArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public SparseBooleanArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._m11.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._m11 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SparseBooleanArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._m12.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._m12 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._m12);
			Init(@__env, handle);
		}
		static SparseBooleanArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
		}
	}
}
