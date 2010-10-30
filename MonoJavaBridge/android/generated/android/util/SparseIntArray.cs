namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseIntArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseIntArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13864;
		public virtual int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "get", "(I)I", ref global::android.util.SparseIntArray._get13864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13865;
		public virtual int get(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "get", "(II)I", ref global::android.util.SparseIntArray._get13865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13866;
		public virtual void put(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "put", "(II)V", ref global::android.util.SparseIntArray._put13866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13867;
		public virtual void append(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "append", "(II)V", ref global::android.util.SparseIntArray._append13867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13868;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "clear", "()V", ref global::android.util.SparseIntArray._clear13868);
		}
		internal static global::MonoJavaBridge.MethodId _size13869;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "size", "()I", ref global::android.util.SparseIntArray._size13869);
		}
		internal static global::MonoJavaBridge.MethodId _delete13870;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "delete", "(I)V", ref global::android.util.SparseIntArray._delete13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13871;
		public virtual int keyAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I", ref global::android.util.SparseIntArray._keyAt13871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13872;
		public virtual int valueAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I", ref global::android.util.SparseIntArray._valueAt13872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13873;
		public virtual int indexOfKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I", ref global::android.util.SparseIntArray._indexOfKey13873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13874;
		public virtual int indexOfValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I", ref global::android.util.SparseIntArray._indexOfValue13874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAt13875;
		public virtual void removeAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V", ref global::android.util.SparseIntArray._removeAt13875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13876;
		public SparseIntArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseIntArray._SparseIntArray13876.native == global::System.IntPtr.Zero)
				global::android.util.SparseIntArray._SparseIntArray13876 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseIntArray13877;
		public SparseIntArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseIntArray._SparseIntArray13877.native == global::System.IntPtr.Zero)
				global::android.util.SparseIntArray._SparseIntArray13877 = @__env.GetMethodIDNoThrow(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray13877);
			Init(@__env, handle);
		}
		static SparseIntArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseIntArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseIntArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}
