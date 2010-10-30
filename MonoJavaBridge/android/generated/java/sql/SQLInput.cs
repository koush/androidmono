namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLInput_))]
	public partial interface SQLInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object readObject();
		int readInt();
		byte[] readBytes();
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		bool readBoolean();
		double readDouble();
		global::java.lang.String readString();
		global::java.sql.Array readArray();
		bool wasNull();
		global::java.math.BigDecimal readBigDecimal();
		global::java.sql.Date readDate();
		global::java.sql.Time readTime();
		global::java.sql.Timestamp readTimestamp();
		global::java.io.Reader readCharacterStream();
		global::java.io.InputStream readAsciiStream();
		global::java.io.InputStream readBinaryStream();
		global::java.sql.Ref readRef();
		global::java.sql.Blob readBlob();
		global::java.sql.Clob readClob();
		global::java.net.URL readURL();
		global::java.lang.String readNString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLInput))]
	internal sealed partial class SQLInput_ : java.lang.Object, SQLInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readObject24983;
		global::java.lang.Object java.sql.SQLInput.readObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readObject24983)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readInt24984;
		int java.sql.SQLInput.readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.SQLInput_._readInt24984);
		}
		internal static global::MonoJavaBridge.MethodId _readBytes24985;
		byte[] java.sql.SQLInput.readBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBytes24985)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readLong24986;
		long java.sql.SQLInput.readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.SQLInput_._readLong24986);
		}
		internal static global::MonoJavaBridge.MethodId _readByte24987;
		byte java.sql.SQLInput.readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallByteMethod(this.JvmHandle, global::java.sql.SQLInput_._readByte24987);
		}
		internal static global::MonoJavaBridge.MethodId _readShort24988;
		short java.sql.SQLInput.readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::java.sql.SQLInput_._readShort24988);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat24989;
		float java.sql.SQLInput.readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.SQLInput_._readFloat24989);
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean24990;
		bool java.sql.SQLInput.readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._readBoolean24990);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble24991;
		double java.sql.SQLInput.readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.SQLInput_._readDouble24991);
		}
		internal static global::MonoJavaBridge.MethodId _readString24992;
		global::java.lang.String java.sql.SQLInput.readString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readString24992)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readArray24993;
		global::java.sql.Array java.sql.SQLInput.readArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readArray24993)) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24994;
		bool java.sql.SQLInput.wasNull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._wasNull24994);
		}
		internal static global::MonoJavaBridge.MethodId _readBigDecimal24995;
		global::java.math.BigDecimal java.sql.SQLInput.readBigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBigDecimal24995)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _readDate24996;
		global::java.sql.Date java.sql.SQLInput.readDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readDate24996)) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _readTime24997;
		global::java.sql.Time java.sql.SQLInput.readTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTime24997)) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _readTimestamp24998;
		global::java.sql.Timestamp java.sql.SQLInput.readTimestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTimestamp24998)) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _readCharacterStream24999;
		global::java.io.Reader java.sql.SQLInput.readCharacterStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readCharacterStream24999)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _readAsciiStream25000;
		global::java.io.InputStream java.sql.SQLInput.readAsciiStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readAsciiStream25000)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBinaryStream25001;
		global::java.io.InputStream java.sql.SQLInput.readBinaryStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBinaryStream25001)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readRef25002;
		global::java.sql.Ref java.sql.SQLInput.readRef()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readRef25002)) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _readBlob25003;
		global::java.sql.Blob java.sql.SQLInput.readBlob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBlob25003)) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _readClob25004;
		global::java.sql.Clob java.sql.SQLInput.readClob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readClob25004)) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _readURL25005;
		global::java.net.URL java.sql.SQLInput.readURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readURL25005)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _readNString25006;
		global::java.lang.String java.sql.SQLInput.readNString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readNString25006)) as java.lang.String;
		}
		static SQLInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLInput"));
			global::java.sql.SQLInput_._readObject24983 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.sql.SQLInput_._readInt24984 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readInt", "()I");
			global::java.sql.SQLInput_._readBytes24985 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBytes", "()[B");
			global::java.sql.SQLInput_._readLong24986 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readLong", "()J");
			global::java.sql.SQLInput_._readByte24987 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readByte", "()B");
			global::java.sql.SQLInput_._readShort24988 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readShort", "()S");
			global::java.sql.SQLInput_._readFloat24989 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readFloat", "()F");
			global::java.sql.SQLInput_._readBoolean24990 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBoolean", "()Z");
			global::java.sql.SQLInput_._readDouble24991 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDouble", "()D");
			global::java.sql.SQLInput_._readString24992 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readString", "()Ljava/lang/String;");
			global::java.sql.SQLInput_._readArray24993 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readArray", "()Ljava/sql/Array;");
			global::java.sql.SQLInput_._wasNull24994 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "wasNull", "()Z");
			global::java.sql.SQLInput_._readBigDecimal24995 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.sql.SQLInput_._readDate24996 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDate", "()Ljava/sql/Date;");
			global::java.sql.SQLInput_._readTime24997 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTime", "()Ljava/sql/Time;");
			global::java.sql.SQLInput_._readTimestamp24998 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTimestamp", "()Ljava/sql/Timestamp;");
			global::java.sql.SQLInput_._readCharacterStream24999 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.SQLInput_._readAsciiStream25000 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readBinaryStream25001 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBinaryStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readRef25002 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readRef", "()Ljava/sql/Ref;");
			global::java.sql.SQLInput_._readBlob25003 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBlob", "()Ljava/sql/Blob;");
			global::java.sql.SQLInput_._readClob25004 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readClob", "()Ljava/sql/Clob;");
			global::java.sql.SQLInput_._readURL25005 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readURL", "()Ljava/net/URL;");
			global::java.sql.SQLInput_._readNString25006 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readNString", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
