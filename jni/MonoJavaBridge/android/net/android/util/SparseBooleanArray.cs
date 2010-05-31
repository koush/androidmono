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
		internal static global::net.sf.jni4net.jni.MethodId _get7613; 
		public virtual bool get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._get7613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get7613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7614; 
		public virtual bool get(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._get7614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._get7614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7615; 
		public virtual void put(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._put7615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._put7615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7616; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._clear7616); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._clear7616); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7617; 
		public virtual void append(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._append7617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._append7617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7618; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._size7618); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._size7618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7619; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.util.SparseBooleanArray._delete7619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._delete7619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7620; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._keyAt7620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._keyAt7620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7621; 
		public virtual bool valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.util.SparseBooleanArray._valueAt7621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._valueAt7621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7622; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._indexOfKey7622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfKey7622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7623; 
		public virtual int indexOfValue(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.util.SparseBooleanArray._indexOfValue7623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._indexOfValue7623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray7624; 
		public SparseBooleanArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray7624, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray7625; 
		public SparseBooleanArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, global::android.util.SparseBooleanArray._SparseBooleanArray7625, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseBooleanArray.staticClass = @__class; 
			global::android.util.SparseBooleanArray._get7613 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z"); 
			global::android.util.SparseBooleanArray._get7614 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z"); 
			global::android.util.SparseBooleanArray._put7615 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V"); 
			global::android.util.SparseBooleanArray._clear7616 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "clear", "()V"); 
			global::android.util.SparseBooleanArray._append7617 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V"); 
			global::android.util.SparseBooleanArray._size7618 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "size", "()I"); 
			global::android.util.SparseBooleanArray._delete7619 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseBooleanArray._keyAt7620 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseBooleanArray._valueAt7621 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z"); 
			global::android.util.SparseBooleanArray._indexOfKey7622 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseBooleanArray._indexOfValue7623 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I"); 
			global::android.util.SparseBooleanArray._SparseBooleanArray7624 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseBooleanArray._SparseBooleanArray7625 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
