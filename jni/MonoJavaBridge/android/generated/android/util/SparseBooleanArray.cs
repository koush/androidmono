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
		internal static global::MonoJavaBridge.MethodId _get13786;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get13786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get13787;
		public virtual bool get(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._get13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put13788;
		public virtual void put(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._put13788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put13788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _append13789;
		public virtual void append(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._append13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear13790;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._clear13790);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear13790);
		}
		internal static global::MonoJavaBridge.MethodId _size13791;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._size13791);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size13791);
		}
		internal static global::MonoJavaBridge.MethodId _delete13792;
		public virtual void delete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray._delete13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keyAt13793;
		public virtual int keyAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._keyAt13793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt13793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueAt13794;
		public virtual bool valueAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray._valueAt13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfKey13795;
		public virtual int indexOfKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfKey13795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey13795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfValue13796;
		public virtual int indexOfValue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray._indexOfValue13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13797;
		public SparseBooleanArray(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SparseBooleanArray13798;
		public SparseBooleanArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray13798);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.SparseBooleanArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/SparseBooleanArray"));
			global::android.util.SparseBooleanArray._get13786 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			global::android.util.SparseBooleanArray._get13787 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			global::android.util.SparseBooleanArray._put13788 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::android.util.SparseBooleanArray._append13789 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::android.util.SparseBooleanArray._clear13790 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::android.util.SparseBooleanArray._size13791 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			global::android.util.SparseBooleanArray._delete13792 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::android.util.SparseBooleanArray._keyAt13793 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseBooleanArray._valueAt13794 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			global::android.util.SparseBooleanArray._indexOfKey13795 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseBooleanArray._indexOfValue13796 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			global::android.util.SparseBooleanArray._SparseBooleanArray13797 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseBooleanArray._SparseBooleanArray13798 = @__env.GetMethodIDNoThrow(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
		}
	}
}
