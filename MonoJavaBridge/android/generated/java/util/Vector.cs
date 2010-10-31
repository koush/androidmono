namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vector : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Vector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.Vector._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.Vector._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.Vector._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Vector._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Vector.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Vector._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "hashCode", "()I", ref global::java.util.Vector._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Vector._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.Vector._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int indexOf(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "indexOf", "(Ljava/lang/Object;I)I", ref global::java.util.Vector._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "clear", "()V", ref global::java.util.Vector._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "isEmpty", "()Z", ref global::java.util.Vector._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int lastIndexOf(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;I)I", ref global::java.util.Vector._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.Vector._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.Vector._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.Vector._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.Vector._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "size", "()I", ref global::java.util.Vector._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Vector.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.Vector._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.Vector.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.Vector._m18) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void addElement(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "addElement", "(Ljava/lang/Object;)V", ref global::java.util.Vector._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.Object elementAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "elementAt", "(I)Ljava/lang/Object;", ref global::java.util.Vector._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.Vector._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.Vector._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Vector.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.util.Vector._m23) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Vector._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void copyInto(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "copyInto", "([Ljava/lang/Object;)V", ref global::java.util.Vector._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "trimToSize", "()V", ref global::java.util.Vector._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "ensureCapacity", "(I)V", ref global::java.util.Vector._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "setSize", "(I)V", ref global::java.util.Vector._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Vector.staticClass, "capacity", "()I", ref global::java.util.Vector._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.lang.Object firstElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "firstElement", "()Ljava/lang/Object;", ref global::java.util.Vector._m30) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.lang.Object lastElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Vector.staticClass, "lastElement", "()Ljava/lang/Object;", ref global::java.util.Vector._m31) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setElementAt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "setElementAt", "(Ljava/lang/Object;I)V", ref global::java.util.Vector._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void removeElementAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "removeElementAt", "(I)V", ref global::java.util.Vector._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void insertElementAt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "insertElementAt", "(Ljava/lang/Object;I)V", ref global::java.util.Vector._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool removeElement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "removeElement", "(Ljava/lang/Object;)Z", ref global::java.util.Vector._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void removeAllElements()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "removeAllElements", "()V", ref global::java.util.Vector._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.Vector._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.Vector._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Vector.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.Vector._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public override global::java.util.List subList(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.Vector.staticClass, "subList", "(II)Ljava/util/List;", ref global::java.util.Vector._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		protected override void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Vector.staticClass, "removeRange", "(II)V", ref global::java.util.Vector._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public Vector(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._m42.native == global::System.IntPtr.Zero)
				global::java.util.Vector._m42 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public Vector(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._m43.native == global::System.IntPtr.Zero)
				global::java.util.Vector._m43 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public Vector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._m44.native == global::System.IntPtr.Zero)
				global::java.util.Vector._m44 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._m44);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public Vector(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Vector._m45.native == global::System.IntPtr.Zero)
				global::java.util.Vector._m45 = @__env.GetMethodIDNoThrow(global::java.util.Vector.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Vector.staticClass, global::java.util.Vector._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Vector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Vector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Vector"));
		}
	}
}
