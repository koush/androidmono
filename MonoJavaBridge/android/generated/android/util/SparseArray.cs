namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;", ref global::android.util.SparseArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::android.util.SparseArray._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void put(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V", ref global::android.util.SparseArray._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void append(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V", ref global::android.util.SparseArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "clear", "()V", ref global::android.util.SparseArray._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseArray.staticClass, "size", "()I", ref global::android.util.SparseArray._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void remove(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "remove", "(I)V", ref global::android.util.SparseArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "delete", "(I)V", ref global::android.util.SparseArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int keyAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseArray.staticClass, "keyAt", "(I)I", ref global::android.util.SparseArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.Object valueAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;", ref global::android.util.SparseArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setValueAt(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V", ref global::android.util.SparseArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int indexOfKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I", ref global::android.util.SparseArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int indexOfValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I", ref global::android.util.SparseArray._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public SparseArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseArray._m13.native == global::System.IntPtr.Zero)
				global::android.util.SparseArray._m13 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public SparseArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseArray._m14.native == global::System.IntPtr.Zero)
				global::android.util.SparseArray._m14 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._m14);
			Init(@__env, handle);
		}
		static SparseArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}
