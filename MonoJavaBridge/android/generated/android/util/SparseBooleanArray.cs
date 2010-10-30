namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseBooleanArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseBooleanArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13851;
		public virtual bool get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._get13851.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._get13851 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13852;
		public virtual bool get(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._get13852.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._get13852 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13853;
		public virtual void put(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._put13853.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._put13853 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put13853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13854;
		public virtual void append(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._append13854.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._append13854 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append13854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13855;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._clear13855.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._clear13855 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear13855);
		}
		internal static global::MonoJavaBridge.MethodId _size13856;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._size13856.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._size13856 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size13856);
		}
		internal static global::MonoJavaBridge.MethodId _delete13857;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._delete13857.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._delete13857 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete13857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13858;
		public virtual int keyAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._keyAt13858.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._keyAt13858 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt13858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13859;
		public virtual bool valueAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._valueAt13859.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._valueAt13859 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13860;
		public virtual int indexOfKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._indexOfKey13860.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._indexOfKey13860 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13861;
		public virtual int indexOfValue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._indexOfValue13861.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._indexOfValue13861 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue13861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13862;
		public SparseBooleanArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._SparseBooleanArray13862.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._SparseBooleanArray13862 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13863;
		public SparseBooleanArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.SparseBooleanArray._SparseBooleanArray13863.native == global::System.IntPtr.Zero)
				global::android.util.SparseBooleanArray._SparseBooleanArray13863 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13863);
			Init(@__env, handle);
		}
		static SparseBooleanArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}
