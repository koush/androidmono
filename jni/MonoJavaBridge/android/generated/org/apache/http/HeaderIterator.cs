namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HeaderIterator : java.util.Iterator
	{
		new bool hasNext();
		global::org.apache.http.Header nextHeader();
	}

	public partial class HeaderIterator_
	{
		public static global::java.lang.Class _class
		{
			get { return __HeaderIterator.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HeaderIterator : java.lang.Object, HeaderIterator
	{
		internal static global::java.lang.Class staticClass;
		static __HeaderIterator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HeaderIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HeaderIterator(@__env);
			}
		}
		internal __HeaderIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext14200;
		 bool org.apache.http.HeaderIterator.hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HeaderIterator._hasNext14200);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HeaderIterator.staticClass, global::org.apache.http.__HeaderIterator._hasNext14200);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextHeader14201;
		 global::org.apache.http.Header org.apache.http.HeaderIterator.nextHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderIterator._nextHeader14201));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderIterator.staticClass, global::org.apache.http.__HeaderIterator._nextHeader14201));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext14202;
		 bool java.util.Iterator.hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HeaderIterator._hasNext14202);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HeaderIterator.staticClass, global::org.apache.http.__HeaderIterator._hasNext14202);
		}
		internal static global::net.sf.jni4net.jni.MethodId _next14203;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderIterator._next14203));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderIterator.staticClass, global::org.apache.http.__HeaderIterator._next14203));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove14204;
		 void java.util.Iterator.remove() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HeaderIterator._remove14204);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HeaderIterator.staticClass, global::org.apache.http.__HeaderIterator._remove14204);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HeaderIterator.staticClass = @__class;
			global::org.apache.http.__HeaderIterator._hasNext14200 = @__env.GetMethodID(global::org.apache.http.__HeaderIterator.staticClass, "org.apache.http.HeaderIterator.hasNext", "()Z");
			global::org.apache.http.__HeaderIterator._nextHeader14201 = @__env.GetMethodID(global::org.apache.http.__HeaderIterator.staticClass, "org.apache.http.HeaderIterator.nextHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.__HeaderIterator._hasNext14202 = @__env.GetMethodID(global::org.apache.http.__HeaderIterator.staticClass, "java.util.Iterator.hasNext", "()Z");
			global::org.apache.http.__HeaderIterator._next14203 = @__env.GetMethodID(global::org.apache.http.__HeaderIterator.staticClass, "java.util.Iterator.next", "()Ljava/lang/Object;");
			global::org.apache.http.__HeaderIterator._remove14204 = @__env.GetMethodID(global::org.apache.http.__HeaderIterator.staticClass, "java.util.Iterator.remove", "()V");
		}
	}
}
