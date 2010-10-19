namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicListHeaderIterator : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicListHeaderIterator()
		{
			InitJNI();
		}
		protected BasicListHeaderIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext26877;
		public virtual bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._hasNext26877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._hasNext26877);
		}
		internal static global::MonoJavaBridge.MethodId _next26878;
		public virtual global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._next26878)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._next26878)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove26879;
		public virtual void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._remove26879);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._remove26879);
		}
		internal static global::MonoJavaBridge.MethodId _findNext26880;
		protected virtual int findNext(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._findNext26880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._findNext26880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextHeader26881;
		public virtual global::org.apache.http.Header nextHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._nextHeader26881)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._nextHeader26881)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _filterHeader26882;
		protected virtual bool filterHeader(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator._filterHeader26882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._filterHeader26882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicListHeaderIterator26883;
		public BasicListHeaderIterator(java.util.List arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._BasicListHeaderIterator26883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicListHeaderIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicListHeaderIterator"));
			global::org.apache.http.message.BasicListHeaderIterator._hasNext26877 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicListHeaderIterator._next26878 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicListHeaderIterator._remove26879 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicListHeaderIterator._findNext26880 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicListHeaderIterator._nextHeader26881 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "nextHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.message.BasicListHeaderIterator._filterHeader26882 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "filterHeader", "(I)Z");
			global::org.apache.http.message.BasicListHeaderIterator._BasicListHeaderIterator26883 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "<init>", "(Ljava/util/List;Ljava/lang/String;)V");
		}
	}
}
