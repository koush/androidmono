namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseBooleanArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SparseBooleanArray()
		{
			InitJNI();
		}
		protected SparseBooleanArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13851;
		public virtual bool get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get13851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13852;
		public virtual bool get(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get13852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13853;
		public virtual void put(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._put13853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put13853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13854;
		public virtual void append(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._append13854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append13854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13855;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._clear13855);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear13855);
		}
		internal static global::MonoJavaBridge.MethodId _size13856;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._size13856);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size13856);
		}
		internal static global::MonoJavaBridge.MethodId _delete13857;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._delete13857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete13857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13858;
		public virtual int keyAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._keyAt13858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt13858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13859;
		public virtual bool valueAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._valueAt13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13860;
		public virtual int indexOfKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfKey13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13861;
		public virtual int indexOfValue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfValue13861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue13861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13862;
		public SparseBooleanArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13863;
		public SparseBooleanArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13863);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
			global::android.util.SparseBooleanArray._get13851 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			global::android.util.SparseBooleanArray._get13852 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			global::android.util.SparseBooleanArray._put13853 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::android.util.SparseBooleanArray._append13854 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::android.util.SparseBooleanArray._clear13855 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::android.util.SparseBooleanArray._size13856 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			global::android.util.SparseBooleanArray._delete13857 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::android.util.SparseBooleanArray._keyAt13858 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseBooleanArray._valueAt13859 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			global::android.util.SparseBooleanArray._indexOfKey13860 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseBooleanArray._indexOfValue13861 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			global::android.util.SparseBooleanArray._SparseBooleanArray13862 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseBooleanArray._SparseBooleanArray13863 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
		}
	}
}
