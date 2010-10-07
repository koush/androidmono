namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SparseBooleanArray : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SparseBooleanArray()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.SparseBooleanArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.SparseBooleanArray(@__env);
			}
		}
		protected SparseBooleanArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8287;
		public virtual bool get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._get8287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get8287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get8288;
		public virtual bool get(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._get8288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get8288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put8289;
		public virtual void put(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._put8289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put8289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append8290;
		public virtual void append(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._append8290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append8290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8291;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._clear8291);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear8291);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8292;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._size8292);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size8292);
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete8293;
		public virtual void delete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._delete8293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete8293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keyAt8294;
		public virtual int keyAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._keyAt8294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt8294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueAt8295;
		public virtual bool valueAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._valueAt8295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt8295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey8296;
		public virtual int indexOfKey(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._indexOfKey8296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey8296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue8297;
		public virtual int indexOfValue(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._indexOfValue8297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue8297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray8298;
		public SparseBooleanArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray8298, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray8299;
		public SparseBooleanArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray8299, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.SparseBooleanArray.staticClass = @__class;
			global::android.util.SparseBooleanArray._get8287 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z");
			global::android.util.SparseBooleanArray._get8288 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z");
			global::android.util.SparseBooleanArray._put8289 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V");
			global::android.util.SparseBooleanArray._append8290 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V");
			global::android.util.SparseBooleanArray._clear8291 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "clear", "()V");
			global::android.util.SparseBooleanArray._size8292 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "size", "()I");
			global::android.util.SparseBooleanArray._delete8293 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V");
			global::android.util.SparseBooleanArray._keyAt8294 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I");
			global::android.util.SparseBooleanArray._valueAt8295 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z");
			global::android.util.SparseBooleanArray._indexOfKey8296 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I");
			global::android.util.SparseBooleanArray._indexOfValue8297 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I");
			global::android.util.SparseBooleanArray._SparseBooleanArray8298 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V");
			global::android.util.SparseBooleanArray._SparseBooleanArray8299 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V");
		}
	}
}
