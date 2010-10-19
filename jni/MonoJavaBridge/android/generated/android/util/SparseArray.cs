namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SparseArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SparseArray()
		{
			InitJNI();
		}
		protected SparseArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get9122;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get9122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get9122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get9123;
		public virtual global::java.lang.Object get(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._get9123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._get9123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put9124;
		public virtual void put(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._put9124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._put9124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append9125;
		public virtual void append(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._append9125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._append9125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear9126;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._clear9126);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._clear9126);
		}
		internal static global::MonoJavaBridge.MethodId _size9127;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._size9127);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._size9127);
		}
		internal static global::MonoJavaBridge.MethodId _remove9128;
		public virtual void remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._remove9128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._remove9128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _delete9129;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._delete9129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._delete9129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt9130;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._keyAt9130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._keyAt9130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt9131;
		public virtual global::java.lang.Object valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.SparseArray._valueAt9131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._valueAt9131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setValueAt9132;
		public virtual void setValueAt(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseArray._setValueAt9132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._setValueAt9132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey9133;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfKey9133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfKey9133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue9134;
		public virtual int indexOfValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseArray._indexOfValue9134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseArray.staticClass, global::android.util.SparseArray._indexOfValue9134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray9135;
		public SparseArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray9135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseArray9136;
		public SparseArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseArray.staticClass, global::android.util.SparseArray._SparseArray9136);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseArray"));
			global::android.util.SparseArray._get9122 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._get9123 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "get", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::android.util.SparseArray._put9124 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "put", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._append9125 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "append", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._clear9126 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "clear", "()V");
			global::android.util.SparseArray._size9127 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "size", "()I");
			global::android.util.SparseArray._remove9128 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "remove", "(I)V");
			global::android.util.SparseArray._delete9129 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "delete", "(I)V");
			global::android.util.SparseArray._keyAt9130 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseArray._valueAt9131 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "valueAt", "(I)Ljava/lang/Object;");
			global::android.util.SparseArray._setValueAt9132 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "setValueAt", "(ILjava/lang/Object;)V");
			global::android.util.SparseArray._indexOfKey9133 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseArray._indexOfValue9134 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "indexOfValue", "(Ljava/lang/Object;)I");
			global::android.util.SparseArray._SparseArray9135 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseArray._SparseArray9136 = @__env.GetMethodIDNoThrow(global::android.util.SparseArray.staticClass, "<init>", "()V");
		}
	}
}
