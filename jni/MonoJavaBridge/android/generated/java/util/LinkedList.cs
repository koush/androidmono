namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedList : java.util.AbstractSequentialList, List, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedList()
		{
			InitJNI();
		}
		protected LinkedList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add20404;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._add20404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add20404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add20405;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._add20405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._add20405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get20406;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._get20406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._get20406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone20407;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._clone20407)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clone20407)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf20408;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._indexOf20408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._indexOf20408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear20409;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._clear20409);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._clear20409);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf20410;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._lastIndexOf20410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._lastIndexOf20410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains20411;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._contains20411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._contains20411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20412;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll20412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll20412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20413;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._addAll20413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addAll20413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size20414;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.LinkedList._size20414);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._size20414);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20415;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray20415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray20415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20416;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._toArray20416)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._toArray20416)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _push20417;
		public virtual void push(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._push20417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._push20417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pop20418;
		public virtual global::java.lang.Object pop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pop20418)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pop20418)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20419;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove20419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove20419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20420;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._remove20420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove20420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20421;
		public virtual global::java.lang.Object remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._remove20421)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._remove20421)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set20422;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._set20422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._set20422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator20423;
		public override global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._listIterator20423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._listIterator20423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _poll20424;
		public virtual global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._poll20424)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._poll20424)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek20425;
		public virtual global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peek20425)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peek20425)) as java.lang.Object;
		}
		public new global::java.lang.Object First
		{
			get
			{
				return getFirst();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirst20426;
		public virtual global::java.lang.Object getFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getFirst20426)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getFirst20426)) as java.lang.Object;
		}
		public new global::java.lang.Object Last
		{
			get
			{
				return getLast();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLast20427;
		public virtual global::java.lang.Object getLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._getLast20427)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._getLast20427)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirst20428;
		public virtual global::java.lang.Object removeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeFirst20428)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirst20428)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeLast20429;
		public virtual global::java.lang.Object removeLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._removeLast20429)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLast20429)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addFirst20430;
		public virtual void addFirst(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addFirst20430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addFirst20430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addLast20431;
		public virtual void addLast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.LinkedList._addLast20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._addLast20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _element20432;
		public virtual global::java.lang.Object element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._element20432)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._element20432)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer20433;
		public virtual bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offer20433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offer20433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerFirst20434;
		public virtual bool offerFirst(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerFirst20434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerFirst20434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offerLast20435;
		public virtual bool offerLast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._offerLast20435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._offerLast20435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekFirst20436;
		public virtual global::java.lang.Object peekFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekFirst20436)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekFirst20436)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peekLast20437;
		public virtual global::java.lang.Object peekLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._peekLast20437)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._peekLast20437)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollFirst20438;
		public virtual global::java.lang.Object pollFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollFirst20438)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollFirst20438)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pollLast20439;
		public virtual global::java.lang.Object pollLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._pollLast20439)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._pollLast20439)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeFirstOccurrence20440;
		public virtual bool removeFirstOccurrence(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeFirstOccurrence20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeFirstOccurrence20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeLastOccurrence20441;
		public virtual bool removeLastOccurrence(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.LinkedList._removeLastOccurrence20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._removeLastOccurrence20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _descendingIterator20442;
		public virtual global::java.util.Iterator descendingIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.LinkedList._descendingIterator20442)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.LinkedList.staticClass, global::java.util.LinkedList._descendingIterator20442)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList20443;
		public LinkedList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList20443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedList20444;
		public LinkedList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedList.staticClass, global::java.util.LinkedList._LinkedList20444);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedList"));
			global::java.util.LinkedList._add20404 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._add20405 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.LinkedList._get20406 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._clone20407 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.LinkedList._indexOf20408 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._clear20409 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "clear", "()V");
			global::java.util.LinkedList._lastIndexOf20410 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.LinkedList._contains20411 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._addAll20412 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.LinkedList._addAll20413 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.LinkedList._size20414 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "size", "()I");
			global::java.util.LinkedList._toArray20415 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.LinkedList._toArray20416 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.LinkedList._push20417 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "push", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._pop20418 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pop", "()Ljava/lang/Object;");
			global::java.util.LinkedList._remove20419 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.LinkedList._remove20420 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._remove20421 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.LinkedList._set20422 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.LinkedList._listIterator20423 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.LinkedList._poll20424 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peek20425 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getFirst20426 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._getLast20427 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "getLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirst20428 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeLast20429 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._addFirst20430 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addFirst", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._addLast20431 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "addLast", "(Ljava/lang/Object;)V");
			global::java.util.LinkedList._element20432 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.LinkedList._offer20433 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerFirst20434 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerFirst", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._offerLast20435 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "offerLast", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._peekFirst20436 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._peekLast20437 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "peekLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollFirst20438 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollFirst", "()Ljava/lang/Object;");
			global::java.util.LinkedList._pollLast20439 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "pollLast", "()Ljava/lang/Object;");
			global::java.util.LinkedList._removeFirstOccurrence20440 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._removeLastOccurrence20441 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
			global::java.util.LinkedList._descendingIterator20442 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "descendingIterator", "()Ljava/util/Iterator;");
			global::java.util.LinkedList._LinkedList20443 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.LinkedList._LinkedList20444 = @__env.GetMethodIDNoThrow(global::java.util.LinkedList.staticClass, "<init>", "()V");
		}
	}
}
