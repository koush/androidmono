namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedList : java.util.AbstractSequentialList, List, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.LinkedList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.LinkedList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.LinkedList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "clear", "()V", ref global::java.util.LinkedList._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.LinkedList._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.LinkedList._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.LinkedList._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.LinkedList.staticClass, "size", "()I", ref global::java.util.LinkedList._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.LinkedList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.LinkedList._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.LinkedList.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.LinkedList._m12) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void push(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "push", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.Object pop()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pop", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m14) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.LinkedList._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.Object remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m17) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.LinkedList._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.util.ListIterator listIterator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.ListIterator>(this, global::java.util.LinkedList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;", ref global::java.util.LinkedList._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ListIterator;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m20) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m21) as java.lang.Object;
		}
		public new global::java.lang.Object First
		{
			get
			{
				return getFirst();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.Object getFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "getFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m22) as java.lang.Object;
		}
		public new global::java.lang.Object Last
		{
			get
			{
				return getLast();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.Object getLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "getLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m23) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.lang.Object removeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "removeFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m24) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.Object removeLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "removeLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m25) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void addFirst(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "addFirst", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void addLast(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.LinkedList.staticClass, "addLast", "(Ljava/lang/Object;)V", ref global::java.util.LinkedList._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.lang.Object element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m28) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool offerFirst(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offerFirst", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool offerLast(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "offerLast", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.lang.Object peekFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peekFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m32) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::java.lang.Object peekLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "peekLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m33) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.lang.Object pollFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pollFirst", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m34) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.Object pollLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.LinkedList.staticClass, "pollLast", "()Ljava/lang/Object;", ref global::java.util.LinkedList._m35) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool removeFirstOccurrence(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool removeLastOccurrence(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.LinkedList.staticClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z", ref global::java.util.LinkedList._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.util.Iterator descendingIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.LinkedList.staticClass, "descendingIterator", "()Ljava/util/Iterator;", ref global::java.util.LinkedList._m38) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public LinkedList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedList._m39.native == global::System.IntPtr.Zero)
				global::java.util.LinkedList._m39 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public LinkedList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.LinkedList._m40.native == global::System.IntPtr.Zero)
				global::java.util.LinkedList._m40 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._m40);
			Init(@__env, handle);
		}
		static LinkedList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
