namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseIntArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseIntArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "get", "(I)I", ref global::android.util.SparseIntArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int get(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "get", "(II)I", ref global::android.util.SparseIntArray._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void put(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "put", "(II)V", ref global::android.util.SparseIntArray._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void append(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "append", "(II)V", ref global::android.util.SparseIntArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "clear", "()V", ref global::android.util.SparseIntArray._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "size", "()I", ref global::android.util.SparseIntArray._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "delete", "(I)V", ref global::android.util.SparseIntArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int keyAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I", ref global::android.util.SparseIntArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int valueAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I", ref global::android.util.SparseIntArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int indexOfKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I", ref global::android.util.SparseIntArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int indexOfValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I", ref global::android.util.SparseIntArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void removeAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V", ref global::android.util.SparseIntArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SparseIntArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseIntArray._m12.native == global::System.IntPtr.Zero)
				global::android.util.SparseIntArray._m12 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public SparseIntArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseIntArray._m13.native == global::System.IntPtr.Zero)
				global::android.util.SparseIntArray._m13 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._m13);
			Init(@__env, handle);
		}
		static SparseIntArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
		}
	}
}
