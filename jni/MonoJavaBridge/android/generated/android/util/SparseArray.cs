namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SparseArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13836;
		public virtual global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get13836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get13836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get13837;
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put13838;
		public virtual void put(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._put13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._put13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13839;
		public virtual void append(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._append13839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._append13839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13840;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._clear13840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._clear13840);
		}
		internal static global::MonoJavaBridge.MethodId _size13841;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._size13841);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._size13841);
		}
		internal static global::MonoJavaBridge.MethodId _remove13842;
		public virtual void remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._remove13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._remove13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _delete13843;
		public virtual void delete(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._delete13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._delete13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13844;
		public virtual int keyAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._keyAt13844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._keyAt13844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13845;
		public virtual global::java.lang.Object valueAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._valueAt13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._valueAt13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setValueAt13846;
		public virtual void setValueAt(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._setValueAt13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._setValueAt13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13847;
		public virtual int indexOfKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfKey13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfKey13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13848;
		public virtual int indexOfValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfValue13848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfValue13848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray13849;
		public SparseArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray13849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray13850;
		public SparseArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray13850);
			Init(@__env, handle);
		}
		static SparseArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseArray"));
			global::android.util.SparseArray._get13836 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._get13837 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::android.util.SparseArray._put13838 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._append13839 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._clear13840 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "clear", "()V");
			global::android.util.SparseArray._size13841 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "size", "()I");
			global::android.util.SparseArray._remove13842 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "remove", "(I)V");
			global::android.util.SparseArray._delete13843 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "delete", "(I)V");
			global::android.util.SparseArray._keyAt13844 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseArray._valueAt13845 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._setValueAt13846 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._indexOfKey13847 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseArray._indexOfValue13848 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I");
			global::android.util.SparseArray._SparseArray13849 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseArray._SparseArray13850 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
