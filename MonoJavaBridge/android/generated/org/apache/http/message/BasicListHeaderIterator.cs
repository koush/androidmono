namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicListHeaderIterator : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicListHeaderIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33625;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._hasNext33625);
		}
		internal static global::MonoJavaBridge.MethodId _next33626;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._next33626)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33627;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._remove33627);
		}
		internal static global::MonoJavaBridge.MethodId _findNext33628;
		protected virtual int findNext(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._findNext33628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextHeader33629;
		public virtual global::org.apache.http.Header nextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._nextHeader33629)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _filterHeader33630;
		protected virtual bool filterHeader(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._filterHeader33630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicListHeaderIterator33631;
		public BasicListHeaderIterator(java.util.List arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicListHeaderIterator.staticClass, global::org.apache.http.message.BasicListHeaderIterator._BasicListHeaderIterator33631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicListHeaderIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicListHeaderIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicListHeaderIterator"));
			global::org.apache.http.message.BasicListHeaderIterator._hasNext33625 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicListHeaderIterator._next33626 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicListHeaderIterator._remove33627 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicListHeaderIterator._findNext33628 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicListHeaderIterator._nextHeader33629 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "nextHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.message.BasicListHeaderIterator._filterHeader33630 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "filterHeader", "(I)Z");
			global::org.apache.http.message.BasicListHeaderIterator._BasicListHeaderIterator33631 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicListHeaderIterator.staticClass, "<init>", "(Ljava/util/List;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
