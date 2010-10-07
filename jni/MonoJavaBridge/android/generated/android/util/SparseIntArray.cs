namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SparseIntArray : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SparseIntArray()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.SparseIntArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.SparseIntArray(@__env);
			}
		}
		protected SparseIntArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8300;
		public virtual int get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._get8300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get8300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8301;
		public virtual int get(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._get8301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._get8301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put8302;
		public virtual void put(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._put8302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._put8302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append8303;
		public virtual void append(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._append8303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._append8303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8304;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._clear8304);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._clear8304);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8305;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._size8305);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._size8305);
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete8306;
		public virtual void delete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._delete8306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._delete8306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keyAt8307;
		public virtual int keyAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._keyAt8307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._keyAt8307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueAt8308;
		public virtual int valueAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._valueAt8308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._valueAt8308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey8309;
		public virtual int indexOfKey(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._indexOfKey8309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfKey8309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue8310;
		public virtual int indexOfValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseIntArray._indexOfValue8310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._indexOfValue8310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAt8311;
		public virtual void removeAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseIntArray._removeAt8311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._removeAt8311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray8312;
		public SparseIntArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray8312, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray8313;
		public SparseIntArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseIntArray.staticClass, global::android.util.SparseIntArray._SparseIntArray8313, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.SparseIntArray.staticClass = @__class;
			global::android.util.SparseIntArray._get8300 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(I)I");
			global::android.util.SparseIntArray._get8301 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(II)I");
			global::android.util.SparseIntArray._put8302 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "put", "(II)V");
			global::android.util.SparseIntArray._append8303 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "append", "(II)V");
			global::android.util.SparseIntArray._clear8304 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "clear", "()V");
			global::android.util.SparseIntArray._size8305 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "size", "()I");
			global::android.util.SparseIntArray._delete8306 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "delete", "(I)V");
			global::android.util.SparseIntArray._keyAt8307 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseIntArray._valueAt8308 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I");
			global::android.util.SparseIntArray._indexOfKey8309 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseIntArray._indexOfValue8310 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I");
			global::android.util.SparseIntArray._removeAt8311 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray8312 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseIntArray._SparseIntArray8313 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "()V");
		}
	}
}
